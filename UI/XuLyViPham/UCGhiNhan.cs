using BLL;
using BLL.Utils;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

        private CongDanBLL _congDanBLL;
        private GiayPhepDAl _giayPheoDAL = new GiayPhepDAl();
        private GiayPhep gp;
        private LoaiViPham lvp;
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

            gp = _giayPhepDAL.GetBySoGiayPhep(soGPLX, "Còn hiệu lực");
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
                            this.pbAnh.Image = Image.FromStream(stream);
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
                lvp = _viPhamDAL.GetById(id);
                Debug.WriteLine(lvp.DiemTru);
                if (lvp != null)
                {
                    this.lbSoDiemTru.Text = lvp.DiemTru.ToString();
                    this.lbMucPhat.Text = "(từ " + lvp.MucPhatTu.ToString() + " đến " + lvp.MucPhatDen.ToString() + ")";
                }
                else
                {
                    this.lbSoDiemTru.Text = "___";
                    this.lbMucPhat.Text = "(từ ___ đến ___)";
                }


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

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (this.gp == null)
            {
                MessageBox.Show("Bạn chưa chọn giấy phép!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.dtpThoiGianViPham.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày vi phạm không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.txtDiaDiem.Text))
            {
                MessageBox.Show("Bạn chưa chọn địa điểm vi phạm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.txtBienKiemSoat.Text))
            {
                MessageBox.Show("Bạn chưa chọn biển kiểm soát!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.txtMucPhat.Text))
            {
                MessageBox.Show("Bạn chưa chọn mức phạt tiền!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (decimal.Parse(txtMucPhat.Text) < this.lvp.MucPhatTu || decimal.Parse(txtMucPhat.Text) > this.lvp.MucPhatDen)
            {
                MessageBox.Show("Mức phạt không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int GPId = gp.GiayPhepId;
            int loaiVP = int.Parse(this.cboLoiViPham.SelectedItem.ToString().Split("-")[0].Trim());
            DateTime tg = this.dtpThoiGianViPham.Value;
            string diaDiem = this.txtDiaDiem.Text;
            string bienKiemSoat = this.txtBienKiemSoat.Text;
            Decimal mucPhat = decimal.Parse(this.txtMucPhat.Text);
            string trangThai = "Đã xử phạt";
            string ghiChu = this.rtbGhiChu.Text;
            Debug.WriteLine(GPId);
            Debug.WriteLine(tg);
            Debug.WriteLine(diaDiem);
            Debug.WriteLine(bienKiemSoat);
            Debug.WriteLine(loaiVP);
            Debug.WriteLine(trangThai);
            Debug.WriteLine(mucPhat);
            ViPham vp = new ViPham()
            {
                GiayPhepId = GPId,
                LoaiViPhamId = loaiVP,
                ThoiGianViPham = tg,
                DiaDiem = diaDiem,
                BienKiemSoat = bienKiemSoat,
                MucPhat = mucPhat,
                TrangThai = trangThai,
                GhiChu = ghiChu,
            };

            try
            {
                this._viPhamDAL.XuLyViPham(vp, int.Parse(this.lbSoDiemConLai.Text));
                DatabaseSession.Context.ViPhams.Add(vp);
                DatabaseSession.Context.SaveChanges();

                // ===== 2️⃣ Cập nhật điểm GPLX =====
                var gp = DatabaseSession.Context.GiayPheps
                                .FirstOrDefault(t => t.GiayPhepId == vp.GiayPhepId);
                Debug.WriteLine("Giấy phép: " + vp.GiayPhepId);
                if (gp == null)
                    throw new Exception("Không tìm thấy giấy phép để cập nhật điểm!");

                int diemMoi = int.Parse(lbSoDiemConLai.Text);
                DatabaseSession.Context.Database.ExecuteSqlRaw(
                     "UPDATE GiayPhep SET SoDiem = {0} WHERE GiayPhepID = {1}", diemMoi, vp.GiayPhepId
                 );
                MessageBox.Show("Đã xử lý GPLX " + this.txtSoGPLX.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    $"Lỗi khi xử lý vi phạm:\n{ex.Message}\n\nChi tiết:\n{ex.InnerException?.Message}",
                    "Lỗi SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }

        }

   

        private void txtMucPhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;   //Ngăn không cho nhập ký tự đó
            }
        }
    }
}
