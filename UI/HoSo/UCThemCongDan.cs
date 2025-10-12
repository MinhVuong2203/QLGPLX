using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.HoSo
{
    public partial class UCThemCongDan : UserControl
    {
        public UCThemCongDan()
        {
            InitializeComponent();
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn ảnh 3x4";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của tệp đã chọn
                    string filePath = openFileDialog.FileName;
                    // Hiển thị ảnh trong PictureBox
                    this.pictureBoxAnhDaiDien.Image = Image.FromFile(filePath);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult rsd = MessageBox.Show(
                "Bạn đã chắn chắc thêm công dân mới!"
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
                congDan.DiaChi = txtDiaChi.Text;
                congDan.SoDienThoai = txtSDT.Text;
                congDan.Email = txtEmail.Text;
                //congDan.AnhDaiDien = pictureBoxAnhDaiDien.Image != null ? (byte[])(new ImageConverter()).ConvertTo(pictureBoxAnhDaiDien.Image, typeof(byte[])) : null;
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
                ,"Xác nhận"
                ,MessageBoxButtons.YesNo
                ,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.txtTen.Text = "";
                this.txtCCCD.Text = "";
                this.txtDiaChi.Text = "";
                this.txtEmail.Text = "";
                this.radioNam.Checked = false;
                this.radioNu.Checked = false;
                this.txtEmail.Text = "";
                this.txtSoGiayKham.Text = "";
                this.dtpNgaySinh.Value = DateTime.Now;
                this.dtpNgayKham.Value = DateTime.Now;
                this.rtxTinhTrang.Text = "";
                this.txtSDT.Text = "";
                this.pictureBoxAnhDaiDien.Image = null;
                this.pictureBoxAnhDaiDien.Image = null;
            }
        }
    }
}
