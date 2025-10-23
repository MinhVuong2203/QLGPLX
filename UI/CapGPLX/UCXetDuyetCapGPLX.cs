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
    public partial class UCXetDuyetCapGPLX : UserControl
    {
        private int gpid = 0;
        public UCXetDuyetCapGPLX()
        {
            InitializeComponent();
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = this.cboMaHang.SelectedItem as string;
            LoadcomboBoxCongDan(maHang);
        }

        private void cboCongDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maCongDan_HoTen = this.cboCongDan.SelectedItem as string;
            if (string.IsNullOrEmpty(maCongDan_HoTen))
            {
                ClearDisplay();
                this.cboCongDan.DataSource = null;
                return;
            }
            string[] parts = maCongDan_HoTen.Split('-');
            int maCongDan = int.Parse(parts[0].Trim());
            string HoTen = parts[1].Trim();
            GiayPhep gp = _giayPhepDAL.GetByMaCongDan(maCongDan, "Chờ xét duyệt");

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
            DialogResult rs = MessageBox.Show("Có chắc chắn cấp GPLX này!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                try
                {
                    // Kiểm tra giấy phép có tồn tại không
                    var exists = DatabaseSession.Context.GiayPheps.Any(g => g.GiayPhepId == gpid);
                    if (!exists)
                    {
                        MessageBox.Show("Không tìm thấy giấy phép!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật bằng Raw SQL
                    DatabaseSession.Context.Database.ExecuteSqlRaw(
                        @"UPDATE GiayPhep 
                        SET TrangThai = {0} 
                        WHERE GiayPhepId = {1}",
                        "Còn hiệu lực", gpid
                    );

                    MessageBox.Show("Giấy phép đã được cấp chính thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
