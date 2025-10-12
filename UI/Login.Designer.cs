

namespace UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public bool IsShowpass = false;

        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            parrotGroupBox = new ReaLTaiizor.Controls.ParrotGroupBox();
            pictureBox1 = new PictureBox();
            skyButton1 = new ReaLTaiizor.Controls.SkyButton();
            btnLogin = new ReaLTaiizor.Controls.SkyButton();
            tbPassword = new ReaLTaiizor.Controls.SkyTextBox();
            label2 = new Label();
            tbUsername = new ReaLTaiizor.Controls.SkyTextBox();
            label1 = new Label();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            parrotGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // parrotGroupBox
            // 
            parrotGroupBox.BackColor = Color.Transparent;
            parrotGroupBox.BorderColor = Color.DodgerBlue;
            parrotGroupBox.BorderWidth = 1;
            parrotGroupBox.Controls.Add(pictureBox1);
            parrotGroupBox.Controls.Add(skyButton1);
            parrotGroupBox.Controls.Add(btnLogin);
            parrotGroupBox.Controls.Add(tbPassword);
            parrotGroupBox.Controls.Add(label2);
            parrotGroupBox.Controls.Add(tbUsername);
            parrotGroupBox.Controls.Add(label1);
            parrotGroupBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotGroupBox.Location = new Point(42, 119);
            parrotGroupBox.Name = "parrotGroupBox";
            parrotGroupBox.ShowText = true;
            parrotGroupBox.Size = new Size(307, 251);
            parrotGroupBox.TabIndex = 0;
            parrotGroupBox.TabStop = false;
            parrotGroupBox.Text = "Đăng nhập hệ thống";
            parrotGroupBox.TextColor = Color.DodgerBlue;
            parrotGroupBox.Enter += parrotGroupBox_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(233, 233, 233);
            pictureBox1.Image = Properties.Resources.CloseEyes;
            pictureBox1.Location = new Point(259, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // skyButton1
            // 
            skyButton1.BackColor = Color.Transparent;
            skyButton1.DownBGColorA = Color.FromArgb(237, 175, 81);
            skyButton1.DownBGColorB = Color.FromArgb(12, 12, 12);
            skyButton1.DownBorderColorA = Color.FromArgb(181, 18, 27);
            skyButton1.DownBorderColorB = Color.FromArgb(12, 12, 12);
            skyButton1.DownBorderColorC = Color.FromArgb(150, 149, 149);
            skyButton1.DownBorderColorD = Color.FromArgb(150, 149, 149);
            skyButton1.DownForeColor = Color.FromArgb(200, 0, 0, 0);
            skyButton1.DownShadowForeColor = Color.White;
            skyButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyButton1.ForeColor = Color.Black;
            skyButton1.HoverBGColorA = Color.FromArgb(181, 18, 27);
            skyButton1.HoverBGColorB = Color.FromArgb(237, 175, 81);
            skyButton1.HoverBorderColorA = Color.FromArgb(181, 18, 27);
            skyButton1.HoverBorderColorB = Color.FromArgb(12, 12, 12);
            skyButton1.HoverBorderColorC = Color.FromArgb(150, 149, 149);
            skyButton1.HoverBorderColorD = Color.FromArgb(150, 149, 149);
            skyButton1.HoverForeColor = Color.White;
            skyButton1.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            skyButton1.Location = new Point(160, 203);
            skyButton1.Name = "skyButton1";
            skyButton1.NormalBGColorA = Color.FromArgb(237, 175, 81);
            skyButton1.NormalBGColorB = Color.FromArgb(226, 221, 154);
            skyButton1.NormalBorderColorA = Color.FromArgb(181, 18, 27);
            skyButton1.NormalBorderColorB = Color.FromArgb(12, 12, 12);
            skyButton1.NormalBorderColorC = Color.FromArgb(150, 149, 149);
            skyButton1.NormalBorderColorD = Color.FromArgb(150, 149, 149);
            skyButton1.NormalForeColor = Color.Black;
            skyButton1.NormalShadowForeColor = Color.White;
            skyButton1.Size = new Size(104, 34);
            skyButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            skyButton1.TabIndex = 6;
            skyButton1.Text = "Thoát";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.DownBGColorA = Color.FromArgb(237, 175, 81);
            btnLogin.DownBGColorB = Color.FromArgb(12, 12, 12);
            btnLogin.DownBorderColorA = Color.FromArgb(181, 18, 27);
            btnLogin.DownBorderColorB = Color.FromArgb(12, 12, 12);
            btnLogin.DownBorderColorC = Color.FromArgb(150, 149, 149);
            btnLogin.DownBorderColorD = Color.FromArgb(150, 149, 149);
            btnLogin.DownForeColor = Color.FromArgb(200, 0, 0, 0);
            btnLogin.DownShadowForeColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.HoverBGColorA = Color.FromArgb(181, 18, 27);
            btnLogin.HoverBGColorB = Color.FromArgb(237, 175, 81);
            btnLogin.HoverBorderColorA = Color.FromArgb(181, 18, 27);
            btnLogin.HoverBorderColorB = Color.FromArgb(12, 12, 12);
            btnLogin.HoverBorderColorC = Color.FromArgb(150, 149, 149);
            btnLogin.HoverBorderColorD = Color.FromArgb(150, 149, 149);
            btnLogin.HoverForeColor = Color.White;
            btnLogin.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnLogin.Location = new Point(40, 203);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBGColorA = Color.FromArgb(237, 175, 81);
            btnLogin.NormalBGColorB = Color.FromArgb(226, 221, 154);
            btnLogin.NormalBorderColorA = Color.FromArgb(181, 18, 27);
            btnLogin.NormalBorderColorB = Color.FromArgb(12, 12, 12);
            btnLogin.NormalBorderColorC = Color.FromArgb(150, 149, 149);
            btnLogin.NormalBorderColorD = Color.FromArgb(150, 149, 149);
            btnLogin.NormalForeColor = Color.Black;
            btnLogin.NormalShadowForeColor = Color.White;
            btnLogin.Size = new Size(104, 34);
            btnLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(233, 233, 233);
            tbPassword.BaseColor = Color.Transparent;
            tbPassword.BorderColorA = Color.FromArgb(255, 128, 0);
            tbPassword.BorderColorB = Color.Black;
            tbPassword.BorderColorC = Color.FromArgb(255, 128, 0);
            tbPassword.BorderColorD = Color.Yellow;
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.FromArgb(27, 94, 137);
            tbPassword.Location = new Point(20, 140);
            tbPassword.MaxLength = 32767;
            tbPassword.MultiLine = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(267, 32);
            tbPassword.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tbPassword.TabIndex = 4;
            tbPassword.Text = "admin@123";
            tbPassword.TextAlignment = HorizontalAlignment.Left;
            tbPassword.UnknownBackColor = Color.FromArgb(43, 43, 43);
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 111);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(233, 233, 233);
            tbUsername.BaseColor = Color.Transparent;
            tbUsername.BorderColorA = Color.FromArgb(255, 128, 0);
            tbUsername.BorderColorB = Color.Black;
            tbUsername.BorderColorC = Color.FromArgb(255, 128, 0);
            tbUsername.BorderColorD = Color.Yellow;
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.FromArgb(27, 94, 137);
            tbUsername.Location = new Point(20, 68);
            tbUsername.MaxLength = 32767;
            tbUsername.MultiLine = false;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(267, 32);
            tbUsername.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tbUsername.TabIndex = 2;
            tbUsername.Text = "AdminVuong";
            tbUsername.TextAlignment = HorizontalAlignment.Left;
            tbUsername.UnknownBackColor = Color.FromArgb(43, 43, 43);
            tbUsername.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 39);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.BackColor = Color.Transparent;
            skyLabel1.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.Maroon;
            skyLabel1.Location = new Point(12, 22);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(362, 35);
            skyLabel1.TabIndex = 1;
            skyLabel1.Text = "HỆ THỐNG QUẢN LÝ";
            // 
            // skyLabel2
            // 
            skyLabel2.AutoSize = true;
            skyLabel2.BackColor = Color.Transparent;
            skyLabel2.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel2.ForeColor = Color.Maroon;
            skyLabel2.Location = new Point(167, 69);
            skyLabel2.Name = "skyLabel2";
            skyLabel2.Size = new Size(492, 35);
            skyLabel2.TabIndex = 2;
            skyLabel2.Text = "GIẤY PHÉP LÁI XE HẠNG A";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgGPLX1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 398);
            Controls.Add(skyLabel2);
            Controls.Add(skyLabel1);
            Controls.Add(parrotGroupBox);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Hệ thống GPLX Hạng A";
            Load += Login_Load;
            parrotGroupBox.ResumeLayout(false);
            parrotGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox;
        private Label label1;
        private ReaLTaiizor.Controls.SkyTextBox tbUsername;
        private ReaLTaiizor.Controls.SkyTextBox tbPassword;
        private Label label2;
        private ReaLTaiizor.Controls.SkyButton btnLogin;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyButton skyButton1;
        private ReaLTaiizor.Controls.ParrotButton BtnShowPass;
        private PictureBox pictureBox1;
    }
}