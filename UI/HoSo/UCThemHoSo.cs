using BLL;
using DAL;
using Microsoft.EntityFrameworkCore;
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


namespace UI.HoSo
{
    public partial class UCThemHoSo : UserControl
    {
        public CanBo canBo { get; set; }
        public UCThemHoSo(CanBo canBo)
        {
            this.canBo = canBo;
            InitializeComponent();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadDataCCCD();
        }

        private void cboCongDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCongDan.SelectedItem == null)
                return;  // không làm gì khi chưa chọn

            string cccd = cboCongDan.SelectedItem.ToString();
            CongDanBLL congDanBLL = new CongDanBLL();
            CongDan congDan = congDanBLL.getCongDanByCCCD(cccd);
            this.idCongDan = congDan.MaCongDan;

            pictureBoxAnhDaiDien.Image = null;

            if (congDan != null)
            {
                txtTen.Text = congDan.HoTen ?? "";
                txtDiaChi.Text = congDan.DiaChi ?? "";
                txtSDT.Text = congDan.SoDienThoai ?? "";
                txtEmail.Text = congDan.Email ?? "";
                txtGioiTinh.Text = congDan.GioiTinh ?? "";

                dtpNgaySinh.Value = congDan.NgaySinh.ToDateTime(new TimeOnly());

                // hiển thị ảnh nếu có
                if (!string.IsNullOrEmpty(congDan.Anh3x4))
                {
                    string solutionPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                    string imagePath = Path.Combine(solutionPath, "Resources", congDan.Anh3x4);

                    if (File.Exists(imagePath))
                    {
                        using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                        pictureBoxAnhDaiDien.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           
            if (this.cboCongDan.SelectedItem == null || this.cboCongDan.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn công dân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
               

            DialogResult rs = MessageBox.Show("Xác nhận thêm hồ sơ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                HoSoBLL hoSoBLL = new HoSoBLL();

                DAL.HoSo hoSo = new DAL.HoSo();
                hoSo.MaCongDan = this.idCongDan;
                Debug.WriteLine(hoSo.MaCongDan);
                hoSo.NgayNop = DateOnly.FromDateTime(dtpNgayNop.Value);
                hoSo.TrangThai = "Đang xử lý";
                hoSo.TrangThaiThanhToan = true;
                hoSo.GhiChu = txtGhiChu.Text;
                hoSo.MaHang = this.comboBox1.SelectedItem.ToString();
                bool success = hoSoBLL.ThemHoSo(hoSo);
                if (success)
                {
                    MessageBox.Show("Thêm hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetForm();
                }
                else
                {
                    MessageBox.Show("Thêm hồ sơ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.idCongDan = -1;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Hủy thêm hồ sơ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                this.resetForm();
                this.idCongDan = -1;
            }
          
        }
    }
}
