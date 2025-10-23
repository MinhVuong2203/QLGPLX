using DAL;
using Microsoft.VisualBasic;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Home : Form
    {
        public CanBo canBo { get; set; }
        public UserControl ucHoSoMain;
        public UserControl ucTrangChu = new TrangChu.UCTrangChuMain();
        public UserControl ucCapGPLX = new CapGPLX.UCCapGPLXMain();
        public UserControl ucKythi = new KyThi.UCKyThiMain();
        public UserControl ucXuLyViPham = new XuLyViPham.UCXuLyViPhamMain();
        public UserControl ucHeThong = new HeThong.UCHeThongMain();
        public int sl = 3;
        public Home(CanBo canBo)
        {
            this.canBo = canBo;
            InitializeComponent();
            loadMenu(canBo);
            LoadInfo(canBo);
            StartClock();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ucHoSoMain = new HoSo.UCHoSoMain(this.canBo);

            Control clickedControl = sender as Control;
            CyberButton clickedButton = clickedControl as CyberButton;
            if (clickedButton == null && clickedControl.Parent is CyberButton)
            {
                clickedButton = clickedControl.Parent as CyberButton;
            }

            // Reset all buttons to default color
            if (this.selectedButton != null)
            {
                selectedButton.RGB = false;
            }
            if (clickedButton != null)
            {
                clickedButton.RGB = true;
                selectedButton = clickedButton; // Lưu lại button hiện tại
            }

            string buttonName = clickedButton?.Name;
            switch (buttonName)
            {
                case "btnTrangChu":
                    this.LoadControl(ucTrangChu);
                    break;
                case "btnHoSo":
                    this.LoadControl(ucHoSoMain);
                    break;
                case "btnKyThi":
                    this.LoadControl(ucKythi);
                    break;
                case "btnCapGPLX":
                    this.LoadControl(ucCapGPLX);
                    break;
                case "btnViPham":
                    this.LoadControl(ucXuLyViPham);
                    break;
                case "btnHeThong":
                    if (sl == 0)
                    {
                        MessageBox.Show("Đã quá số lần");
                        break;
                    }
                    string input = Interaction.InputBox(
                        "Nhập mật khẩu:",     // Nội dung
                        "Xác thực Admin",           // Tiêu đề
                        "",          // Giá trị mặc định
                        -1, -1                     // Vị trí (-1,-1) = giữa màn hình
                    );
                    if (string.IsNullOrEmpty(input)) break;
                    if (PasswordHelper.HashPassword(input).Equals(canBo.Password))
                    {
                        this.LoadControl(ucHeThong);
                        sl = 3;
                    }
                    else {
                        sl--;
                        MessageBox.Show("Mật khẩu không đúng! Còn " + sl + " lần thử");
                        break;
                    }
                        break;
                default:
                    break;
            }



        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void parrotSlidingPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Hide();
                DatabaseSession.Close();
                Application.Restart();
            }
           
        }
    }
}
