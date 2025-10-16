using BLL;
using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI.KyThi
{
    public partial class UCKyThi : UserControl
    {
        private readonly KyThiBLL _bll = new KyThiBLL();
        private DAL.KyThi _selected;


        public UCKyThi()
        {
            InitializeComponent();

            // Wire events
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            dgv.SelectionChanged += Dgv_SelectionChanged;
          
            button1.Click += Button1_Click;

            // initial load
            comboBox1.SelectedIndex = 0;
            LoadList();
            UpdateButtonsState();
        }

        private void LoadList()
        {
            string filter = comboBox1.SelectedItem?.ToString();
            var data = _bll.GetAll(string.IsNullOrEmpty(filter) ? null : filter);
            dgv.DataSource = data.Select(k => new
            {
                k.KyThiId,
                k.TenKyThi,
                GioBatDau = (k.GioBatDau == null ? "" : k.GioBatDau.ToString()),
                k.NgayBatDau,
                k.NgayKetThuc,
                k.DiaDiem,
                k.MaHang,
                k.SoLuongToiDa,
                k.TrangThai,
                DaDangKy = _bll.GetRegisteredCount(k.KyThiId)
            }).ToList();
            // Optionally set column headers explicitly (Vietnamese, spaced nicely)
            if (dgv.Columns["KyThiId"] != null) dgv.Columns["KyThiId"].HeaderText = "Mã kỳ thi";
            if (dgv.Columns["Tên"] != null) dgv.Columns["Tên"].HeaderText = "Tên kỳ thi";
            if (dgv.Columns["NgayBatDau"] != null) dgv.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            if (dgv.Columns["GioBatDau"] != null) dgv.Columns["GioBatDau"].HeaderText = "Giờ bắt đầu";
            if (dgv.Columns["NgayKetThuc"] != null) dgv.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
            if (dgv.Columns["DiaDiem"] != null) dgv.Columns["DiaDiem"].HeaderText = "Địa điểm";
            if (dgv.Columns["MaHang"] != null) dgv.Columns["MaHang"].HeaderText = "Mã hạng";
            if (dgv.Columns["DaDangKy"] != null) dgv.Columns["DaDangKy"].HeaderText = "Đã đăng ký";
            if (dgv.Columns["SoLuongToiDa"] != null) dgv.Columns["SoLuongToiDa"].HeaderText = "Số lượng tối đa";
            if (dgv.Columns["TrangThai"] != null) dgv.Columns["TrangThai"].HeaderText = "Trạng thái";

            UpdateButtonsState();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                var idObj = dgv.SelectedRows[0].Cells["KyThiId"].Value;
                if (idObj != null && int.TryParse(idObj.ToString(), out int id))
                {
                    _selected = _bll.GetById(id);
                }
                else
                {
                    _selected = null;
                }
            }
            else
            {
                _selected = null;
            }
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            bool hasSelection = _selected != null;
            btnSua.Enabled = hasSelection;
            button1.Enabled = hasSelection;

            if (hasSelection && (_selected.TrangThai == "Đang diễn ra" || _selected.TrangThai == "Đã kết thúc"))
            {
                btnSua.Enabled = false;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            using (var f = new FormKyThiEdit())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadList();
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Vui lòng chọn một kỳ thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var f = new FormKyThiEdit(_selected.KyThiId))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadList();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Vui lòng chọn một kỳ thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var f = new FormKyThiParticipants(_selected.KyThiId))
            {
                f.ShowDialog();
            }
        }

     
    }
}
