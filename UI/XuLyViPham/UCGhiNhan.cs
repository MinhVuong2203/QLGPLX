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
    public partial class UCGhiNhan : UserControl
    {
        private int gpid = 0;
        private CongDanBLL _congDanBLL;
        public UCGhiNhan()
        {
            InitializeComponent();
            LoadViPham();
        }



        private void TimGPLX(object sender, EventArgs e)
        {
            string soGPLX = txtSoGPLX.Text;
            if (string.IsNullOrEmpty(soGPLX))
            {
                return;
            }

            GiayPhep gp = _giayPhepDAL.GetBySoGiayPhep(soGPLX, "Còn hiệu lực");
            if (gp != null)
            {
                DateOnly date = DateOnly.FromDateTime(DateTime.Now);
                string[] parts1 = gp.MaCongDanNavigation.DiaChi.Split(",");

                this.LbTen.Text = gp.MaCongDanNavigation.HoTen;
                this.lbNgaySinh.Text = gp.MaCongDanNavigation.NgaySinh.ToString();
                this.lbDiaChiPhuongTinh.Text = parts1[parts1.Length - 2] + ", " + parts1[parts1.Length - 1];
                this.lbDiaChi.Text = "";
                for (int i = 0; i < parts1.Length - 2; i++)
                    this.lbDiaChi.Text += parts1[i] + ", ";
                this.LbHang.Text = gp.MaHang;
                this.lbNgayThangNam.Text = "An Giang, " + "ngày/date " + date.Day.ToString() + " tháng/month " + date.Month.ToString() + " năm/year " + date.Year.ToString();
                this.lbSo.Text = gp.SoGiayPhep;
                this.lbSoDiemHienCo.Text = gp.SoDiem.ToString();

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
            else
            {
                MessageBox.Show("Số giấy phép không hợp lệ hoặc chưa chính thức!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void cboLoiViPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Loai_Ten = this.cboLoiViPham.SelectedItem as string;
            if (!string.IsNullOrEmpty(Loai_Ten))
            {
                int id = int.Parse(Loai_Ten.Split("-")[0].Trim());
                LoaiViPham vp = _viPhamDAL.GetById(id);
                Debug.WriteLine(vp.DiemTru);
                if (vp != null)
                    this.lbSoDiemTru.Text = vp.DiemTru.ToString();
                else
                    this.lbSoDiemTru.Text = "___";
            }
        }

        private void lbSoDiemHienCo_Leave(object sender, EventArgs e)
        {
            if (lbSoDiemHienCo.Text == "___" || string.IsNullOrEmpty(lbSoDiemHienCo.Text))
            {
                lbSoDiemConLai.Text = "___";
                return;
            }
            if (lbSoDiemTru.Text == "___" || string.IsNullOrEmpty(lbSoDiemTru.Text))
            {
                lbSoDiemConLai.Text = lbSoDiemConLai.Text.Trim();
                return;
            }
            int sdhc = int.Parse((lbSoDiemHienCo.Text));
            int sdt = int.Parse((lbSoDiemTru.Text));
            int sdcl = sdhc - sdt;
            lbSoDiemConLai.Text = (sdcl) < 0 ? "0" : sdcl.ToString();
        }
    }
}
