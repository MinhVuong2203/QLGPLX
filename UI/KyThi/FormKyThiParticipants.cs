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
            dgvParticipants.DataSource = list.Select(k => new
            {
                k.HoSo.HoSoId,
                MaCongDan = k.HoSo.MaCongDan,
                HoTen = k.HoSo.MaCongDanNavigation?.HoTen,
                k.LanThi,
                Ngày = k.NgayKetLuan
            }).ToList();

            // style grid
            dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParticipants.DefaultCellStyle.ForeColor = Color.Black;
            dgvParticipants.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 230, 210);
            dgvParticipants.EnableHeadersVisualStyles = false;

            // remove existing action columns
            if (dgvParticipants.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "btnDelete"))
                dgvParticipants.Columns.Remove("btnDelete");
            if (dgvParticipants.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "btnRetry"))
                dgvParticipants.Columns.Remove("btnRetry");

            // Add action column depending on KyThi.TrangThai
            var ky = _bll.GetById(_kyThiId);
            if (ky != null && ky.TrangThai != null)
            {
                if (ky.TrangThai.Trim() == "Sắp diễn ra")
                {
                    var btnDelete = new DataGridViewButtonColumn
                    {
                        Name = "btnDelete",
                        HeaderText = "Hành động",
                        Text = "Xóa",
                        UseColumnTextForButtonValue = true,
                        Width = 90
                    };
                    dgvParticipants.Columns.Add(btnDelete);
                }
                else if (ky.TrangThai.Trim() == "Đang diễn ra")
                {
                    var btnRetry = new DataGridViewButtonColumn
                    {
                        Name = "btnRetry",
                        HeaderText = "Hành động",
                        Text = "Thi lại",
                        UseColumnTextForButtonValue = true,
                        Width = 90
                    };
                    dgvParticipants.Columns.Add(btnRetry);
                }
            }

            // ensure handler (avoid multiple subscriptions)
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

        private void DgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dgvParticipants.Columns[e.ColumnIndex];

            // get HoSoId from the row data
            var hoSoIdObj = dgvParticipants.Rows[e.RowIndex].Cells["HoSoId"].Value;
            if (hoSoIdObj == null) return;
            if (!int.TryParse(hoSoIdObj.ToString(), out int hoSoId)) return;

            var ky = _bll.GetById(_kyThiId);
            if (ky == null) return;

            try
            {
                if (col.Name == "btnDelete")
                {
                    // Remove participant and push back to pending
                    var confirm = MessageBox.Show("Xác nhận xóa thí sinh khỏi kỳ thi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        _bll.RemoveParticipant(_kyThiId, hoSoId);
                        MessageBox.Show("Đã xóa thí sinh khỏi kỳ thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParticipants();
                        LoadPending();
                    }
                }
                else if (col.Name == "btnRetry")
                {
                    // Try to add a retry attempt
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}