using BLL;
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

namespace UI.CapGPLX
{
    public partial class UCCapLaiGPLX : UserControl
    {
        private int gpid = 0;
        private CongDanBLL _congDanBLL;
        public UCCapLaiGPLX()
        {
            InitializeComponent();
        }



        private void TimGPLX(object sender, EventArgs e)
        {
            string soGPLX = txtSoGPLX.Text;
            if (string.IsNullOrEmpty(soGPLX))
            {
                return;
            }

            GiayPhep gp = _giayPhepDAL.GetBySoGiayPhep(soGPLX);

            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            gpid = gp.GiayPhepId;
            string[] parts1 = gp.MaCongDanNavigation.DiaChi.Split(",");

            this.LbTen.Text = gp.MaCongDanNavigation.HoTen;
            this.lbNgaySinh.Text = gp.MaCongDanNavigation.NgaySinh.ToString();
            this.lbDiaChiPhuongTinh.Text = parts1[parts1.Length - 2] + ", " + parts1[parts1.Length - 1];
            this.lbDiaChi.Text = "";
            for (int i = 0; i < parts1.Length - 2; i++)
                this.lbDiaChi.Text += parts1[i] + ", ";
            this.lbMota.Text = gp.MaHangNavigation.MoTa;
            this.lbNgay.Text = gp.NgayCap.ToString();
            this.LbHang.Text = gp.MaHang;
            this.lbNgayThangNam.Text = "An Giang, " + "ngày/date " + date.Day.ToString() + " tháng/month " + date.Month.ToString() + " năm/year " + date.Year.ToString();
            this.lbSo.Text = gp.SoGiayPhep;

            if (gp.MaCongDanNavigation.Anh3x4 != null)
            {
                string solutionPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string imagePath = Path.Combine(solutionPath, "Resources", gp.MaCongDanNavigation.Anh3x4);
                Debug.WriteLine(solutionPath);
                Debug.WriteLine(imagePath);
                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        this.pictureBoxAnh.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Có chắc chắn cấp lại GPLX này!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                GiayPhep oldGp = _giayPhepDAL.GetBySoGiayPhep(this.txtSoGPLX.Text);
                GiayPhep newGp = new GiayPhep
                {
                    MaCongDan = oldGp.MaCongDan,
                    MaHang = oldGp.MaHang,
                    SoGiayPhep = oldGp.SoGiayPhep,
                    NgayCap = DateOnly.FromDateTime(DateTime.Now),
                    NgayHetHan = oldGp.NgayHetHan,
                    SoDiem = oldGp.SoDiem,
                    TrangThai = "Còn hiệu lực",
                    GhiChu = "Cấp lại\nLý do: " + rtbLyDo.Text
                };

                try
                {   
                    DatabaseSession.Context.GiayPheps.Add(newGp);
                    DatabaseSession.Context.SaveChanges();
                    MessageBox.Show("Giấy phép đã được cấp lại chính thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xả ra!" + ex.Message);
                }
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void lbNgayThangNam_Click(object sender, EventArgs e)
        {

        }
    }
}
