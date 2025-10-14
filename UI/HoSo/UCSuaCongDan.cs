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
    public partial class UCSuaCongDan : UserControl
    {
        public UCSuaCongDan()
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
                this.pictureBoxAnhDaiDien.Image = null;
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
    }
}
