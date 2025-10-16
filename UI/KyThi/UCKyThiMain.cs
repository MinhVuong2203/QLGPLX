using BLL;
using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI.KyThi
{
    public partial class UCKyThiMain : UserControl
    {
        private readonly KyThiBLL _bll = new KyThiBLL();
        private DAL.KyThi _selected;

        public UCKyThiMain()
        {
            InitializeComponent();

            // Wire events
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            dgv.SelectionChanged += Dgv_SelectionChanged;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
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
                k.TrangThai,
                k.NgayBatDau,
                k.NgayKetThuc,
                k.DiaDiem,
                k.MaHang,
                k.SoLuongToiDa
            }).ToList();

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
