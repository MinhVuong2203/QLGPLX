using BLL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI.KyThi
{
    public partial class FormKyThiParticipants : Form
    {
        private readonly KyThiBLL _bll = new KyThiBLL();
        private readonly int _kyThiId;

        // Designer controls
        private Label lblHeader;
        private DataGridView dgvParticipants;
        private Panel panelTop;
        public FormKyThiParticipants()
        {
            InitializeComponent();
        }
        public FormKyThiParticipants(int kyThiId)
        {
            _kyThiId = kyThiId;
            InitializeComponent();
            LoadParticipants();
            LoadPending();
        }

        private void LoadParticipants()
        {
            var list = _bll.GetParticipants(_kyThiId);
            // include KetQuaTongHop in the datasource so we can decide per-row action
            dgvParticipants.DataSource = list.Select(k => new
            {
                k.HoSo.HoSoId,
                MaCongDan = k.HoSo.MaCongDan,
                HoTen = k.HoSo.MaCongDanNavigation?.HoTen,
                k.LanThi,
                Ngày = k.NgayKetLuan,
                KetQuaTongHop = k.KetQuaTongHop
            }).ToList();

            // style grid
            dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParticipants.DefaultCellStyle.ForeColor = Color.Black;
            dgvParticipants.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 230, 210);
            dgvParticipants.EnableHeadersVisualStyles = false;

            // Ensure single action column exists (per-row text will decide Xóa/Thi lại/empty)
            var actionColName = "btnAction";
            if (!dgvParticipants.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == actionColName))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = actionColName,
                    HeaderText = "Hành động",
                    UseColumnTextForButtonValue = false,
                    Width = 100
                };
                dgvParticipants.Columns.Add(btnCol);
            }

            // wire DataBindingComplete to set per-row button text/state
            dgvParticipants.DataBindingComplete -= DgvParticipants_DataBindingComplete;
            dgvParticipants.DataBindingComplete += DgvParticipants_DataBindingComplete;

            // wire cell click handler (ensure single subscription)
            dgvParticipants.CellContentClick -= DgvParticipants_CellContentClick;
            dgvParticipants.CellContentClick += DgvParticipants_CellContentClick;
        }

        private void LoadPending()
        {
            var ky = _bll.GetById(_kyThiId);
            if (ky == null)
            {
                label1.Visible = false;
                dgvPending.Visible = false;
                return;
            }

            // hide pending section if KyThi đã kết thúc
            if (ky.TrangThai != null && ky.TrangThai.Trim() == "Đã kết thúc")
            {
                label1.Visible = false;
                dgvPending.Visible = false;
                return;
            }

            label1.Visible = true;
            dgvPending.Visible = true;

            var pending = _bll.GetPendingHoSoForKyThi(_kyThiId);
            dgvPending.DataSource = pending.Select(h => new
            {
                h.HoSoId,
                MaCongDan = h.MaCongDan,
                HoTen = h.MaCongDanNavigation?.HoTen,
                h.MaHang,
                NgàyNộp = h.NgayNop
            }).ToList();

            // add Thêm button column if not exists
            var btnColName = "btnAdd";
            if (!dgvPending.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == btnColName))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = btnColName,
                    HeaderText = "Thao tác",
                    Text = "Thêm",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dgvPending.Columns.Add(btnCol);
            }

            // aesthetics
            dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPending.DefaultCellStyle.ForeColor = Color.Black;
            dgvPending.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 230, 210);
            dgvPending.EnableHeadersVisualStyles = false;
        }

        private void DgvPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dgvPending.Columns[e.ColumnIndex];
            if (col is DataGridViewButtonColumn)
            {
                // add participant
                var hoSoIdObj = dgvPending.Rows[e.RowIndex].Cells["HoSoId"].Value;
                if (hoSoIdObj == null) return;
                if (!int.TryParse(hoSoIdObj.ToString(), out int hoSoId)) return;

                try
                {
                    _bll.AddParticipant(_kyThiId, hoSoId);
                    MessageBox.Show("Đã thêm công dân vào kỳ thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // refresh both lists
                    LoadParticipants();
                    LoadPending();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DgvParticipants_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_kyThiId <= 0) return;
            var ky = _bll.GetById(_kyThiId);
            if (ky == null) return;

            bool isSap = string.Equals(ky.TrangThai?.Trim(), "Sắp diễn ra", StringComparison.OrdinalIgnoreCase);
            bool isDang = string.Equals(ky.TrangThai?.Trim(), "Đang diễn ra", StringComparison.OrdinalIgnoreCase);

            foreach (DataGridViewRow row in dgvParticipants.Rows)
            {
                var actionCell = row.Cells["btnAction"] as DataGridViewCell;
                if (actionCell == null) continue;

                string ketQua = (row.Cells["KetQuaTongHop"]?.Value ?? "").ToString().Trim();

                if (isSap)
                {
                    actionCell.Value = "Xóa";
                    actionCell.Style.ForeColor = Color.Black;
                    actionCell.Style.BackColor = Color.LightSalmon;
                    actionCell.ReadOnly = false;
                }
                else if (isDang)
                {
                    if (string.Equals(ketQua, "Không đạt", StringComparison.OrdinalIgnoreCase))
                    {
                        actionCell.Value = "Thi lại";
                        actionCell.Style.ForeColor = Color.Black;
                        actionCell.Style.BackColor = Color.LightGreen;
                        actionCell.ReadOnly = false;
                    }
                    else
                    {
                        // hide/disable action for this row
                        actionCell.Value = "";
                        actionCell.Style.ForeColor = Color.Gray;
                        actionCell.Style.BackColor = dgvParticipants.DefaultCellStyle.BackColor;
                        actionCell.ReadOnly = true;
                    }
                }
                else
                {
                    // exam finished or other status: hide button
                    actionCell.Value = "";
                    actionCell.Style.ForeColor = Color.Gray;
                    actionCell.Style.BackColor = dgvParticipants.DefaultCellStyle.BackColor;
                    actionCell.ReadOnly = true;
                }
            }
        }
        private void DgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dgvParticipants.Columns[e.ColumnIndex];
            if (col == null) return;
            if (col.Name != "btnAction") return;

            var cell = dgvParticipants.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var action = (cell.Value ?? "").ToString();
            if (string.IsNullOrEmpty(action)) return; // nothing to do

            // get HoSoId from row
            var hoSoIdObj = dgvParticipants.Rows[e.RowIndex].Cells["HoSoId"].Value;
            if (hoSoIdObj == null) return;
            if (!int.TryParse(hoSoIdObj.ToString(), out int hoSoId)) return;

            var ky = _bll.GetById(_kyThiId);
            if (ky == null) return;

            try
            {
                if (action == "Xóa")
                {
                    var confirm = MessageBox.Show("Xác nhận xóa thí sinh khỏi kỳ thi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        _bll.RemoveParticipant(_kyThiId, hoSoId);
                        MessageBox.Show("Đã xóa thí sinh khỏi kỳ thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParticipants();
                        LoadPending();
                    }
                }
                else if (action == "Thi lại")
                {
                    // Only allow retry for ongoing exams and when current overall result is "Không đạt"
                    if (!string.Equals(ky.TrangThai?.Trim(), "Đang diễn ra", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Chỉ được phép thi lại khi kỳ thi đang diễn ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // verify latest overall result is "Không đạt"
                    var ketQuaTongHop = dgvParticipants.Rows[e.RowIndex].Cells["KetQuaTongHop"].Value?.ToString() ?? "";
                    if (!string.Equals(ketQuaTongHop, "Không đạt", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Thí sinh không ở trạng thái 'Không đạt' nên không thể thi lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var success = _bll.RetryParticipant(_kyThiId, hoSoId);
                    if (success)
                    {
                        MessageBox.Show("Đã ghi nhận lần thi lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParticipants();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thi lại (đã đạt tối đa 3 lần).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ... other methods remain unchanged ...
    }
}