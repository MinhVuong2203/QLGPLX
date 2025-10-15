using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Helpers;

namespace UI.HoSo
{
    public partial class UCThemCongDan : UserControl
    {
        public UCThemCongDan()
        {
            InitializeComponent();
            LoadDiaChiFromJson();
            LoadTinh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCThemCongDan_Load(object sender, EventArgs e)
        {

        }

        private void btnChonAnh3x4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtTen.Text) || string.IsNullOrWhiteSpace(this.txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cá nhân trước khi chọn ảnh!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string tenFile = $"Anh3x4_{txtCCCD.Text}";
            string rs = ImageHelper.LuuAnh(pictureBoxAnhDaiDien, tenFile);
            if (!string.IsNullOrEmpty(rs))
            {
                this.duongDanAnh3x4 = rs;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.congDanBLL = new BLL.CongDanBLL();
            DialogResult rsd = MessageBox.Show(
                "Xác nhận thêm công dân mới!"
                , "Xác nhận"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (rsd == DialogResult.No) return;
            try
            {
                CongDan congDan = new CongDan();
                congDan.HoTen = txtTen.Text;
                congDan.Cccd = txtCCCD.Text;
                if (radioNam.Checked)
                    congDan.GioiTinh = "Nam";
                else if (radioNu.Checked)
                    congDan.GioiTinh = "Nữ";
                congDan.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
                congDan.DiaChi = txtSoNha.Text + ", " + cbPhuongXa.SelectedItem?.ToString() + ", " + cbTinh.SelectedItem?.ToString();
                congDan.SoDienThoai = txtSDT.Text;
                congDan.Email = txtEmail.Text;
                congDan.Anh3x4 = this.duongDanAnh3x4;
                congDan.NgayKhamSucKhoe = DateOnly.FromDateTime(dtpNgayKham.Value);
                congDan.GiayKhamSucKhoe = this.duongDanAnhGiayKham;

                bool rs = this.congDanBLL.ThemCongDan(congDan);
                if (rs)
                {
                    MessageBox.Show("Thêm công dân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.setDefaltInfo();
                }
                else
                {
                    MessageBox.Show("Không thể thêm công dân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void skyButton1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn đặt lại tất cả bản ghi!"
                , "Xác nhận"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.txtTen.Text = "";
                this.txtCCCD.Text = "";
                this.txtSoNha.Text = "";
                this.cbTinh.SelectedIndex = -1;
                this.cbPhuongXa.DataSource = null;
                this.txtEmail.Text = "";
                this.radioNam.Checked = false;
                this.radioNu.Checked = false;
                this.txtEmail.Text = "";
                this.dtpNgaySinh.Value = DateTime.Now;
                this.dtpNgayKham.Value = DateTime.Now;
                this.rtxTinhTrang.Text = "";
                this.txtSDT.Text = "";
                this.pictureBoxAnhDaiDien.Image = null;
                this.pictureBoxAnhGiayKham.Image = null;
            }
        }

        private void btnChonAnhGiayKham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cá nhân trước khi chọn ảnh!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            string tenFile = $"AnhGiayKham_{txtCCCD.Text}";
            string rs = ImageHelper.LuuAnh(pictureBoxAnhGiayKham, tenFile);
            if (!string.IsNullOrEmpty(rs))
            {
                this.duongDanAnhGiayKham = rs;
                Debug.WriteLine(this.duongDanAnhGiayKham);
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTinh = cbTinh.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTinh)) return;

            var phuongXas = diaChiList
                .FirstOrDefault(x => x.tentinhmoi == selectedTinh)
                ?.phuongxa
                .Select(x => x.tenphuongxa)
                .ToList() ?? new List<string>();

            cbPhuongXa.DataSource = new List<string>(phuongXas);
        }

        private void TxtCCCD_GotFocus(object sender, EventArgs e)
        {
            txtSearch.BackColor = Color.WhiteSmoke;
            txtSearch.Text = "";
        }

        private void TxtCCCD_LostFocus(object sender, EventArgs e)
        {
            txtSearch.BackColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.congDanBLL = new BLL.CongDanBLL();
            this.setDefaltInfo();
            string cccd = txtSearch.Text.Trim();
            CongDan congDan = congDanBLL.getCongDanByCCCD(cccd);
            if (congDan != null)
            {                  
                this.txtCCCD.Text = congDan.Cccd;
                this.txtTen.Text = congDan.HoTen;
                this.txtSDT.Text = congDan.SoDienThoai;
                this.txtEmail.Text = congDan.Email;
                if (congDan.GioiTinh == "Nam")
                    this.radioNam.Checked = true;
                else if (congDan.GioiTinh == "Nữ")
                    this.radioNu.Checked = true;
                this.dtpNgaySinh.Value = congDan.NgaySinh.ToDateTime(new TimeOnly(0, 0));
                if (congDan.GiayKhamSucKhoe != null)
                    this.dtpNgayKham.Value = congDan.NgayKhamSucKhoe?.ToDateTime(new TimeOnly(0, 0)) ?? DateTime.Now;
                string diachi = congDan.DiaChi;

                if (!string.IsNullOrWhiteSpace(diachi))
                {
                    var parts = diachi.Split(',')
                                      .Select(p => p.Trim())
                                      .ToList();

                    // --- 1. Tách phần tỉnh (cuối)
                    string tinh = parts.LastOrDefault();
                    if (!string.IsNullOrEmpty(tinh))
                    {
                        int indexTinh = cbTinh.Items.IndexOf(tinh);
                        if (indexTinh >= 0)
                            cbTinh.SelectedIndex = indexTinh;
                        else
                            cbTinh.SelectedIndex = -1; // không tìm thấy
                    }

                    // --- 2. Tách phần phường (gần cuối)
                    if (parts.Count >= 2)
                    {
                        string phuong = parts[parts.Count - 2];
                        int indexPhuong = cbPhuongXa.Items.IndexOf(phuong);
                        if (indexPhuong >= 0)
                            cbPhuongXa.SelectedIndex = indexPhuong;
                        else
                            cbPhuongXa.SelectedIndex = -1;
                    }

                    // --- 3. Phần còn lại là số nhà + đường
                    if (parts.Count > 2)
                        txtSoNha.Text = string.Join(", ", parts.Take(parts.Count - 2));
                    else
                        txtSoNha.Text = diachi;
                } 
                else
                {
                    this.cbPhuongXa.SelectedIndex = -1;
                    this.cbTinh.SelectedIndex = -1;
                    this.txtSoNha.Text = "";
                }
                this.rtxTinhTrang.Text = congDan.TinhTrangSucKhoe;
                this.duongDanAnh3x4 = congDan.Anh3x4;
                this.duongDanAnhGiayKham = congDan.GiayKhamSucKhoe;
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
                if (congDan.GiayKhamSucKhoe != null)
                {
                    string solutionPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                    string imagePath = Path.Combine(solutionPath, "Resources", congDan.GiayKhamSucKhoe);
                    Debug.WriteLine(solutionPath);
                    Debug.WriteLine(imagePath);
                    if (File.Exists(imagePath))
                    {
                        using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            this.pictureBoxAnhGiayKham.Image = Image.FromStream(stream);
                        }
                    }
                }
                this.btnCapNhat.Enabled = true;
                this.txtCCCD.Enabled = false;
                this.btnSubmit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy công dân với CCCD: " + cccd, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnCapNhat.Enabled = false;
                this.txtCCCD.Enabled = false;
                this.btnSubmit.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            this.congDanBLL = new BLL.CongDanBLL();
            DialogResult rsd = MessageBox.Show(
                "Xác nhận cập nhật thông tin công dân!"
                , "Xác nhận"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (rsd == DialogResult.No) return;
            try
            {
                CongDan congDan = new CongDan();
                congDan.HoTen = txtTen.Text;
                congDan.Cccd = txtCCCD.Text;
                if (radioNam.Checked)
                    congDan.GioiTinh = "Nam";
                else if (radioNu.Checked)
                    congDan.GioiTinh = "Nữ";
                congDan.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
                congDan.DiaChi = txtSoNha.Text + ", " + cbPhuongXa.SelectedItem?.ToString() + ", " + cbTinh.SelectedItem?.ToString();
                congDan.SoDienThoai = txtSDT.Text;
                congDan.Email = txtEmail.Text;
                congDan.Anh3x4 = this.duongDanAnh3x4;
                congDan.NgayKhamSucKhoe = DateOnly.FromDateTime(dtpNgayKham.Value);
                congDan.GiayKhamSucKhoe = this.duongDanAnhGiayKham;

                bool rs = this.congDanBLL.CapNhatCongDan(congDan);
                if (rs)
                {
                    MessageBox.Show("Cập nhật công dân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnSubmit.Enabled = true;
                    this.txtCCCD.Enabled = true;
                    this.btnCapNhat.Enabled = false;
                    this.txtSearch.Text = "Nhập CCCD";
                    this.setDefaltInfo();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin công dân thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
