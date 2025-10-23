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
            } else
            {
                MessageBox.Show("Số giấy phép không hợp lệ hoặc chưa chính thức!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Có chắc chắn cấp lại GPLX này!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                GiayPhep oldGp = _giayPhepDAL.GetBySoGiayPhep(this.txtSoGPLX.Text, "Còn hiệu lực");

                string newSoGiayPhep = "R" + oldGp.MaHang
                    + DateOnly.FromDateTime(DateTime.Now).Year
                    + DateOnly.FromDateTime(DateTime.Now).Month
                    + DateOnly.FromDateTime(DateTime.Now).Day
                    + oldGp.MaCongDan;

                string ghiChu = "Cấp lại\nLý do: " + rtbLyDo.Text + "\nSố cũ: " + oldGp.SoGiayPhep;

                try
                {
                    // Cập nhật trạng thái bản cũ
                    string sqlUpdate = @"UPDATE GiayPhep 
                                SET TrangThai = N'Bị thu hồi' 
                                WHERE SoGiayPhep = {0} AND TrangThai = N'Còn hiệu lực'";
                    DatabaseSession.Context.Database.ExecuteSqlRaw(sqlUpdate, oldGp.SoGiayPhep);

                    // Thêm giấy phép mới
                    string sqlInsert = @"INSERT INTO GiayPhep (MaCongDan, MaHang, SoGiayPhep, NgayCap, NgayHetHan, SoDiem, TrangThai, GhiChu)
                                VALUES ({0}, {1}, {2}, {3}, {4}, {5}, N'Còn hiệu lực', {6})";

                    DatabaseSession.Context.Database.ExecuteSqlRaw(sqlInsert,
                        oldGp.MaCongDan,
                        oldGp.MaHang,
                        newSoGiayPhep,
                        DateOnly.FromDateTime(DateTime.Now),
                        oldGp.NgayHetHan,
                        oldGp.SoDiem,
                        ghiChu);

                    MessageBox.Show("Giấy phép đã được cấp lại chính thức!\n" +
                        "Số GPLX mới: " + newSoGiayPhep, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    this.txtSoGPLX.Text = newSoGiayPhep;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Đã quá số lần cấp GPLX trong ngày ",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


    }
}
