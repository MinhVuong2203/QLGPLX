using DAL;
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
        public UserControl ucHoSoMain = new HoSo.UCHoSoMain();
        public UserControl ucTrangChu = new TrangChu.UCTrangChuMain();
        public UserControl ucCapGPLX = new CapGPLX.UCCapGPLXMain();
        public UserControl ucKythi = new KyThi.UCKyThiMain();
        public UserControl ucXuLyViPham = new XuLyViPham.UCXuLyViPhamMain();
        public UserControl ucHeThong = new HeThong.UCHeThongMain();

        public Home(CanBo canBo)
        {
            InitializeComponent();
            loadMenu(canBo);
            LoadInfo(canBo);
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
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
                    this.LoadControl(ucHeThong);
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
    }
}
