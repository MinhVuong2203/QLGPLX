using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using UI.Helpers;

namespace UI.HoSo
{
    public partial class UCDuyetHoSo : UserControl
    {
        private string AnhGiayKham = "";
        private HoSoBLL hoSoBLL = new HoSoBLL();
        private List<DAL.HoSo> hoSoList;
        private DAL.HoSo selectedHoSo;

        public CanBo canBo { get; set; }

        public UCDuyetHoSo(CanBo canBo)
        {
            this.canBo = canBo;
            InitializeComponent();
            LoadHoSoList("");
            btnDuyet.Enabled = false;
            btnTuChoi.Enabled = false;
            dgvHoSo.SelectionChanged += DgvHoSo_SelectionChanged;
            btnDuyet.Click += BtnDuyet_Click;
            btnTuChoi.Click += BtnTuChoi_Click;
        }

        private void LoadHoSoList(string TrangThai)
        {
            hoSoList = hoSoBLL.GetAllHoSo(TrangThai);
            dgvHoSo.DataSource = hoSoList;

            // Đặt tiêu đề tiếng Việt cho các cột
            dgvHoSo.Columns["HoSoId"].HeaderText = "Mã Hồ Sơ";
            dgvHoSo.Columns["MaCongDan"].HeaderText = "Mã Công Dân";
            dgvHoSo.Columns["MaHang"].HeaderText = "Hạng";
            dgvHoSo.Columns["NgayNop"].HeaderText = "Ngày Nộp";
            dgvHoSo.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvHoSo.Columns["TrangThaiThanhToan"].HeaderText = "Thanh Toán";
            dgvHoSo.Columns["GhiChu"].HeaderText = "Ghi Chú";

            // Đặt màu chữ cho dữ liệu là màu đen
            dgvHoSo.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvHoSo.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        private void DgvHoSo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoSo.SelectedRows.Count > 0)
            {
                selectedHoSo = dgvHoSo.SelectedRows[0].DataBoundItem as DAL.HoSo;
                ShowCongDanDetails(selectedHoSo.MaCongDanNavigation);
                btnDuyet.Enabled = true;
                btnTuChoi.Enabled = true;
            }
            else
            {
                btnDuyet.Enabled = false;
                btnTuChoi.Enabled = false;
            }
        }

        private void ShowCongDanDetails(CongDan congDan)
        {
            txtTen.Text = congDan.HoTen;
            txtCCCD.Text = congDan.Cccd;
            txtNgaySinh.Text = congDan.NgaySinh.ToString("dd-MM-yyyy");
            txtGioiTinh.Text = congDan.GioiTinh;
            txtDiaChi.Text = congDan.DiaChi;
            txtSDT.Text = congDan.SoDienThoai;
            txtEmail.Text = congDan.Email;
            txtNgayKham.Text = congDan.NgayKhamSucKhoe?.ToString("dd-MM-yyyy");
            rtxTinhTrang.Text = congDan.TinhTrangSucKhoe;
            this.AnhGiayKham = congDan.GiayKhamSucKhoe;
            if (congDan.Anh3x4 != null)
            {
                string solutionPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string imagePath = Path.Combine(solutionPath, "Resources", congDan.Anh3x4);
                Debug.WriteLine(solutionPath);
                Debug.WriteLine(imagePath);
                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        this.pictureBoxAnhDaiDien.Image = Image.FromStream(stream);
                    }
                }
            }
            this.AnhGiayKham = congDan.GiayKhamSucKhoe;


        }

        private void BtnDuyet_Click(object sender, EventArgs e)
        {
            if (selectedHoSo != null)
            {
                hoSoBLL.DuyetHoSo(selectedHoSo.HoSoId, canBo.MaCanBo);
                MessageBox.Show("Hồ sơ đã được duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoSoList(this.cbTrangThai.SelectedItem.ToString());
            }
        }

        private void BtnTuChoi_Click(object sender, EventArgs e)
        {
            if (selectedHoSo != null)
            {
                hoSoBLL.TuChoiHoSo(selectedHoSo.HoSoId, canBo.MaCanBo);
                MessageBox.Show("Hồ sơ đã bị từ chối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoSoList(this.cbTrangThai.SelectedItem.ToString());
            }
        }

        private void btnChonAnhGiayKham_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AnhGiayKham))
            {
                var viewForm = new FormViewImage(AnhGiayKham); // chỉ truyền tên file
                viewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoSoList(this.cbTrangThai.SelectedItem.ToString());
        }
    }
}
