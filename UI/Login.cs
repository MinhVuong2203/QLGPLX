using DAL;
using BLL;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UI
{
    public partial class Login : Form
    {
        private UserBLL userBLL = new UserBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void parrotGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                CanBo canbo = userBLL.Login(username, password);
                Debug.WriteLine(canbo.MaCanBo);
                if (canbo != null)
                {
                    new Home(canbo).Show();
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.IsShowpass)
            {
                pictureBox1.Image = UI.Properties.Resources.CloseEyes;

                tbPassword.UseSystemPasswordChar = true;
                this.IsShowpass = false;
            }
            else
            {
                pictureBox1.Image = UI.Properties.Resources.OpenEyes;

                tbPassword.UseSystemPasswordChar = false;
                this.IsShowpass = true;
            }
        }
    }
}
