using ReaLTaiizor.Manager;
using static ReaLTaiizor.Controls.HopeTabPage;
using ReaLTaiizor.Controls;
using System.Drawing;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Util;
using DAL;



namespace UI
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private CyberButton selectedButton { get; set; }// Biến để lưu button hiện tại
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
            btnCapGPLX = new CyberButton();
            btnHoSo = new CyberButton();
            btnTrangChu = new CyberButton();
            btnKyThi = new CyberButton();
            panel1 = new System.Windows.Forms.Panel();
            parrotGradientPanel1 = new ParrotGradientPanel();
            panel2 = new System.Windows.Forms.Panel();
            lblDate = new Label();
            lblClock = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            parrotSlidingPanel2 = new ParrotSlidingPanel();
            lbRole = new Label();
            lbName = new Label();
            anhDaiDien = new ParrotPictureBox();
            parrotSlidingPanel1 = new ParrotSlidingPanel();
            iconHeThong = new Label();
            iconViPham = new Label();
            iconHoSo = new Label();
            iconCapGPLX = new Label();
            iconKyThi = new Label();
            btnHeThong = new CyberButton();
            btnViPham = new CyberButton();
            iconTrangChu = new Label();
            panelMain = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            parrotGradientPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            parrotSlidingPanel2.SuspendLayout();
            parrotSlidingPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCapGPLX
            // 
            btnCapGPLX.Alpha = 20;
            btnCapGPLX.BackColor = Color.Transparent;
            btnCapGPLX.Background = true;
            btnCapGPLX.Background_WidthPen = 12F;
            btnCapGPLX.BackgroundImageLayout = ImageLayout.Zoom;
            btnCapGPLX.BackgroundPen = true;
            btnCapGPLX.ColorBackground = Color.FromArgb(37, 52, 68);
            btnCapGPLX.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCapGPLX.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCapGPLX.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCapGPLX.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCapGPLX.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCapGPLX.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCapGPLX.Cursor = Cursors.Hand;
            btnCapGPLX.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCapGPLX.Dock = DockStyle.Top;
            btnCapGPLX.Effect_1 = true;
            btnCapGPLX.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCapGPLX.Effect_1_Transparency = 25;
            btnCapGPLX.Effect_2 = true;
            btnCapGPLX.Effect_2_ColorBackground = Color.White;
            btnCapGPLX.Effect_2_Transparency = 20;
            btnCapGPLX.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapGPLX.ForeColor = Color.FromArgb(245, 245, 245);
            btnCapGPLX.Lighting = false;
            btnCapGPLX.LinearGradient_Background = false;
            btnCapGPLX.LinearGradientPen = false;
            btnCapGPLX.Location = new Point(0, 243);
            btnCapGPLX.Name = "btnCapGPLX";
            btnCapGPLX.PenWidth = 15;
            btnCapGPLX.Rounding = true;
            btnCapGPLX.RoundingInt = 70;
            btnCapGPLX.Size = new Size(240, 81);
            btnCapGPLX.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCapGPLX.TabIndex = 11;
            btnCapGPLX.Tag = "Cyber";
            btnCapGPLX.TextButton = "Cấp GPLX";
            btnCapGPLX.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCapGPLX.Timer_Effect_1 = 1;
            btnCapGPLX.Timer_RGB = 100;
            btnCapGPLX.Click += MenuItem_Click;
            // 
            // btnHoSo
            // 
            btnHoSo.Alpha = 20;
            btnHoSo.BackColor = Color.Transparent;
            btnHoSo.Background = true;
            btnHoSo.Background_WidthPen = 12F;
            btnHoSo.BackgroundImageLayout = ImageLayout.Zoom;
            btnHoSo.BackgroundPen = true;
            btnHoSo.ColorBackground = Color.FromArgb(37, 52, 68);
            btnHoSo.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnHoSo.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnHoSo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnHoSo.ColorLighting = Color.FromArgb(29, 200, 238);
            btnHoSo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnHoSo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnHoSo.Cursor = Cursors.Hand;
            btnHoSo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnHoSo.Dock = DockStyle.Top;
            btnHoSo.Effect_1 = true;
            btnHoSo.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnHoSo.Effect_1_Transparency = 25;
            btnHoSo.Effect_2 = true;
            btnHoSo.Effect_2_ColorBackground = Color.White;
            btnHoSo.Effect_2_Transparency = 20;
            btnHoSo.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            btnHoSo.ForeColor = Color.FromArgb(245, 245, 245);
            btnHoSo.Lighting = false;
            btnHoSo.LinearGradient_Background = false;
            btnHoSo.LinearGradientPen = false;
            btnHoSo.Location = new Point(0, 81);
            btnHoSo.Name = "btnHoSo";
            btnHoSo.PenWidth = 15;
            btnHoSo.Rounding = true;
            btnHoSo.RoundingInt = 70;
            btnHoSo.Size = new Size(240, 81);
            btnHoSo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnHoSo.TabIndex = 10;
            btnHoSo.Tag = "Cyber";
            btnHoSo.TextButton = "Hồ sơ";
            btnHoSo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnHoSo.Timer_Effect_1 = 1;
            btnHoSo.Timer_RGB = 100;
            btnHoSo.Click += MenuItem_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Alpha = 5;
            btnTrangChu.BackColor = Color.Transparent;
            btnTrangChu.Background = true;
            btnTrangChu.Background_WidthPen = 12F;
            btnTrangChu.BackgroundImageLayout = ImageLayout.Zoom;
            btnTrangChu.BackgroundPen = true;
            btnTrangChu.ColorBackground = Color.FromArgb(37, 52, 68);
            btnTrangChu.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnTrangChu.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnTrangChu.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnTrangChu.ColorLighting = Color.FromArgb(29, 200, 238);
            btnTrangChu.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnTrangChu.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnTrangChu.Cursor = Cursors.Hand;
            btnTrangChu.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.Effect_1 = true;
            btnTrangChu.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnTrangChu.Effect_1_Transparency = 10;
            btnTrangChu.Effect_2 = true;
            btnTrangChu.Effect_2_ColorBackground = Color.White;
            btnTrangChu.Effect_2_Transparency = 20;
            btnTrangChu.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            btnTrangChu.ForeColor = Color.FromArgb(245, 245, 245);
            btnTrangChu.Lighting = false;
            btnTrangChu.LinearGradient_Background = false;
            btnTrangChu.LinearGradientPen = false;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.PenWidth = 15;
            btnTrangChu.Rounding = true;
            btnTrangChu.RoundingInt = 70;
            btnTrangChu.Size = new Size(240, 81);
            btnTrangChu.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnTrangChu.TabIndex = 9;
            btnTrangChu.Tag = "Cyber";
            btnTrangChu.TextButton = "Trang chủ";
            btnTrangChu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnTrangChu.Timer_Effect_1 = 1;
            btnTrangChu.Timer_RGB = 100;
            btnTrangChu.Click += MenuItem_Click;
            // 
            // btnKyThi
            // 
            btnKyThi.Alpha = 20;
            btnKyThi.BackColor = Color.Transparent;
            btnKyThi.Background = true;
            btnKyThi.Background_WidthPen = 12F;
            btnKyThi.BackgroundImageLayout = ImageLayout.Zoom;
            btnKyThi.BackgroundPen = true;
            btnKyThi.ColorBackground = Color.FromArgb(37, 52, 68);
            btnKyThi.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnKyThi.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnKyThi.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnKyThi.ColorLighting = Color.FromArgb(29, 200, 238);
            btnKyThi.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnKyThi.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnKyThi.Cursor = Cursors.Hand;
            btnKyThi.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnKyThi.Dock = DockStyle.Top;
            btnKyThi.Effect_1 = true;
            btnKyThi.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnKyThi.Effect_1_Transparency = 25;
            btnKyThi.Effect_2 = true;
            btnKyThi.Effect_2_ColorBackground = Color.White;
            btnKyThi.Effect_2_Transparency = 20;
            btnKyThi.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            btnKyThi.ForeColor = Color.FromArgb(245, 245, 245);
            btnKyThi.Lighting = false;
            btnKyThi.LinearGradient_Background = false;
            btnKyThi.LinearGradientPen = false;
            btnKyThi.Location = new Point(0, 162);
            btnKyThi.Name = "btnKyThi";
            btnKyThi.PenWidth = 15;
            btnKyThi.Rounding = true;
            btnKyThi.RoundingInt = 70;
            btnKyThi.Size = new Size(240, 81);
            btnKyThi.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnKyThi.TabIndex = 8;
            btnKyThi.Tag = "Cyber";
            btnKyThi.TextButton = "Kỳ thi";
            btnKyThi.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnKyThi.Timer_Effect_1 = 1;
            btnKyThi.Timer_RGB = 100;
            btnKyThi.Click += MenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(parrotGradientPanel1);
            panel1.Controls.Add(parrotSlidingPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 84);
            panel1.TabIndex = 6;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.Black;
            parrotGradientPanel1.BottomRight = Color.Fuchsia;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(panel2);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(240, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(1024, 84);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 1;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.Fuchsia;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(lblClock);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(790, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 84);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ActiveCaptionText;
            lblDate.Location = new Point(63, 50);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(173, 31);
            lblDate.TabIndex = 6;
            lblDate.Text = "Giờ";
            // 
            // lblClock
            // 
            lblClock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClock.ForeColor = SystemColors.ActiveCaptionText;
            lblClock.Location = new Point(63, 14);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(173, 31);
            lblClock.TabIndex = 4;
            lblClock.Text = "Giờ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.imgClock;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 50);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.imgCalender;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(20, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // parrotSlidingPanel2
            // 
            parrotSlidingPanel2.BottomLeft = Color.Black;
            parrotSlidingPanel2.BottomRight = Color.DodgerBlue;
            parrotSlidingPanel2.CollapseControl = null;
            parrotSlidingPanel2.Collapsed = true;
            parrotSlidingPanel2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotSlidingPanel2.Controls.Add(lbRole);
            parrotSlidingPanel2.Controls.Add(lbName);
            parrotSlidingPanel2.Controls.Add(anhDaiDien);
            parrotSlidingPanel2.Dock = DockStyle.Left;
            parrotSlidingPanel2.HideControls = false;
            parrotSlidingPanel2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotSlidingPanel2.Location = new Point(0, 0);
            parrotSlidingPanel2.Name = "parrotSlidingPanel2";
            parrotSlidingPanel2.PanelWidthCollapsed = 50;
            parrotSlidingPanel2.PanelWidthExpanded = 200;
            parrotSlidingPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSlidingPanel2.PrimerColor = Color.White;
            parrotSlidingPanel2.Size = new Size(240, 84);
            parrotSlidingPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotSlidingPanel2.Style = ParrotGradientPanel.GradientStyle.Corners;
            parrotSlidingPanel2.TabIndex = 0;
            parrotSlidingPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSlidingPanel2.TopLeft = Color.Black;
            parrotSlidingPanel2.TopRight = Color.Black;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.BackColor = Color.Transparent;
            lbRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbRole.ForeColor = Color.Black;
            lbRole.Location = new Point(69, 46);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(57, 17);
            lbRole.TabIndex = 2;
            lbRole.Text = "Chức vụ:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(69, 19);
            lbName.Name = "lbName";
            lbName.Size = new Size(64, 20);
            lbName.TabIndex = 1;
            lbName.Text = "lbName";
            // 
            // anhDaiDien
            // 
            anhDaiDien.BackColor = Color.Transparent;
            anhDaiDien.ColorLeft = Color.Transparent;
            anhDaiDien.ColorRight = Color.Transparent;
            anhDaiDien.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            anhDaiDien.FilterAlpha = 0;
            anhDaiDien.FilterEnabled = true;
            anhDaiDien.Image = Properties.Resources.Employee_default;
            anhDaiDien.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            anhDaiDien.IsElipse = true;
            anhDaiDien.IsParallax = false;
            anhDaiDien.Location = new Point(5, 11);
            anhDaiDien.Name = "anhDaiDien";
            anhDaiDien.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            anhDaiDien.Size = new Size(60, 60);
            anhDaiDien.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            anhDaiDien.TabIndex = 0;
            anhDaiDien.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // parrotSlidingPanel1
            // 
            parrotSlidingPanel1.BottomLeft = Color.Black;
            parrotSlidingPanel1.BottomRight = Color.DodgerBlue;
            parrotSlidingPanel1.CollapseControl = null;
            parrotSlidingPanel1.Collapsed = true;
            parrotSlidingPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotSlidingPanel1.Controls.Add(iconHeThong);
            parrotSlidingPanel1.Controls.Add(iconViPham);
            parrotSlidingPanel1.Controls.Add(iconHoSo);
            parrotSlidingPanel1.Controls.Add(iconCapGPLX);
            parrotSlidingPanel1.Controls.Add(iconKyThi);
            parrotSlidingPanel1.Controls.Add(btnHeThong);
            parrotSlidingPanel1.Controls.Add(btnViPham);
            parrotSlidingPanel1.Controls.Add(iconTrangChu);
            parrotSlidingPanel1.Controls.Add(btnCapGPLX);
            parrotSlidingPanel1.Controls.Add(btnKyThi);
            parrotSlidingPanel1.Controls.Add(btnHoSo);
            parrotSlidingPanel1.Controls.Add(btnTrangChu);
            parrotSlidingPanel1.Dock = DockStyle.Left;
            parrotSlidingPanel1.HideControls = false;
            parrotSlidingPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotSlidingPanel1.Location = new Point(0, 84);
            parrotSlidingPanel1.Name = "parrotSlidingPanel1";
            parrotSlidingPanel1.PanelWidthCollapsed = 50;
            parrotSlidingPanel1.PanelWidthExpanded = 200;
            parrotSlidingPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSlidingPanel1.PrimerColor = Color.White;
            parrotSlidingPanel1.Size = new Size(240, 580);
            parrotSlidingPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotSlidingPanel1.Style = ParrotGradientPanel.GradientStyle.Corners;
            parrotSlidingPanel1.TabIndex = 12;
            parrotSlidingPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSlidingPanel1.TopLeft = Color.Black;
            parrotSlidingPanel1.TopRight = Color.Black;
            // 
            // iconHeThong
            // 
            iconHeThong.BackColor = Color.Transparent;
            iconHeThong.Image = Properties.Resources.Home12;
            iconHeThong.Location = new Point(28, 421);
            iconHeThong.Name = "iconHeThong";
            iconHeThong.Size = new Size(50, 50);
            iconHeThong.TabIndex = 25;
            // 
            // iconViPham
            // 
            iconViPham.BackColor = Color.Transparent;
            iconViPham.Image = Properties.Resources.Home12;
            iconViPham.Location = new Point(28, 340);
            iconViPham.Name = "iconViPham";
            iconViPham.Size = new Size(50, 50);
            iconViPham.TabIndex = 24;
            // 
            // iconHoSo
            // 
            iconHoSo.BackColor = Color.Transparent;
            iconHoSo.Image = Properties.Resources.Home12;
            iconHoSo.Location = new Point(28, 97);
            iconHoSo.Name = "iconHoSo";
            iconHoSo.Size = new Size(50, 50);
            iconHoSo.TabIndex = 21;
            // 
            // iconCapGPLX
            // 
            iconCapGPLX.BackColor = Color.Transparent;
            iconCapGPLX.Image = Properties.Resources.Home12;
            iconCapGPLX.Location = new Point(28, 259);
            iconCapGPLX.Name = "iconCapGPLX";
            iconCapGPLX.Size = new Size(50, 50);
            iconCapGPLX.TabIndex = 23;
            // 
            // iconKyThi
            // 
            iconKyThi.BackColor = Color.Transparent;
            iconKyThi.Image = Properties.Resources.Home12;
            iconKyThi.Location = new Point(28, 178);
            iconKyThi.Name = "iconKyThi";
            iconKyThi.Size = new Size(50, 50);
            iconKyThi.TabIndex = 22;
            // 
            // btnHeThong
            // 
            btnHeThong.Alpha = 20;
            btnHeThong.BackColor = Color.Transparent;
            btnHeThong.Background = true;
            btnHeThong.Background_WidthPen = 12F;
            btnHeThong.BackgroundImageLayout = ImageLayout.Zoom;
            btnHeThong.BackgroundPen = true;
            btnHeThong.ColorBackground = Color.FromArgb(37, 52, 68);
            btnHeThong.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnHeThong.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnHeThong.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnHeThong.ColorLighting = Color.FromArgb(29, 200, 238);
            btnHeThong.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnHeThong.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnHeThong.Cursor = Cursors.Hand;
            btnHeThong.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnHeThong.Dock = DockStyle.Top;
            btnHeThong.Effect_1 = true;
            btnHeThong.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnHeThong.Effect_1_Transparency = 25;
            btnHeThong.Effect_2 = true;
            btnHeThong.Effect_2_ColorBackground = Color.White;
            btnHeThong.Effect_2_Transparency = 20;
            btnHeThong.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeThong.ForeColor = Color.FromArgb(245, 245, 245);
            btnHeThong.Lighting = false;
            btnHeThong.LinearGradient_Background = false;
            btnHeThong.LinearGradientPen = false;
            btnHeThong.Location = new Point(0, 405);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.PenWidth = 15;
            btnHeThong.Rounding = true;
            btnHeThong.RoundingInt = 70;
            btnHeThong.Size = new Size(240, 81);
            btnHeThong.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnHeThong.TabIndex = 19;
            btnHeThong.Tag = "Cyber";
            btnHeThong.TextButton = "Hệ thống";
            btnHeThong.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnHeThong.Timer_Effect_1 = 1;
            btnHeThong.Timer_RGB = 100;
            btnHeThong.Click += MenuItem_Click;
            // 
            // btnViPham
            // 
            btnViPham.Alpha = 20;
            btnViPham.BackColor = Color.Transparent;
            btnViPham.Background = true;
            btnViPham.Background_WidthPen = 12F;
            btnViPham.BackgroundImageLayout = ImageLayout.Zoom;
            btnViPham.BackgroundPen = true;
            btnViPham.ColorBackground = Color.FromArgb(37, 52, 68);
            btnViPham.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnViPham.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnViPham.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnViPham.ColorLighting = Color.FromArgb(29, 200, 238);
            btnViPham.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnViPham.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnViPham.Cursor = Cursors.Hand;
            btnViPham.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnViPham.Dock = DockStyle.Top;
            btnViPham.Effect_1 = true;
            btnViPham.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnViPham.Effect_1_Transparency = 25;
            btnViPham.Effect_2 = true;
            btnViPham.Effect_2_ColorBackground = Color.White;
            btnViPham.Effect_2_Transparency = 20;
            btnViPham.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViPham.ForeColor = Color.FromArgb(245, 245, 245);
            btnViPham.Lighting = false;
            btnViPham.LinearGradient_Background = false;
            btnViPham.LinearGradientPen = false;
            btnViPham.Location = new Point(0, 324);
            btnViPham.Name = "btnViPham";
            btnViPham.PenWidth = 15;
            btnViPham.Rounding = true;
            btnViPham.RoundingInt = 70;
            btnViPham.Size = new Size(240, 81);
            btnViPham.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnViPham.TabIndex = 17;
            btnViPham.Tag = "Cyber";
            btnViPham.TextButton = "Vi phạm";
            btnViPham.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnViPham.Timer_Effect_1 = 1;
            btnViPham.Timer_RGB = 100;
            btnViPham.Click += MenuItem_Click;
            // 
            // iconTrangChu
            // 
            iconTrangChu.BackColor = Color.Transparent;
            iconTrangChu.Cursor = Cursors.Hand;
            iconTrangChu.Image = Properties.Resources.Home12;
            iconTrangChu.Location = new Point(28, 17);
            iconTrangChu.Name = "iconTrangChu";
            iconTrangChu.Size = new Size(50, 50);
            iconTrangChu.TabIndex = 13;
            iconTrangChu.Click += MenuItem_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(240, 84);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1024, 580);
            panelMain.TabIndex = 13;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1264, 664);
            Controls.Add(panelMain);
            Controls.Add(parrotSlidingPanel1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLight;
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            parrotGradientPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            parrotSlidingPanel2.ResumeLayout(false);
            parrotSlidingPanel2.PerformLayout();
            parrotSlidingPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        public void loadMenu(CanBo canBo)
        {
            this.iconTrangChu.Parent = btnTrangChu;
            this.btnTrangChu.RGB = true; 
            this.selectedButton = btnTrangChu;
            this.iconHoSo.Parent = btnHoSo;
            this.iconKyThi.Parent = btnKyThi;
            this.iconViPham.Parent = btnViPham;
            this.iconCapGPLX.Parent = btnCapGPLX;
            this.iconHeThong.Parent = btnHeThong;
            this.LoadControl(ucTrangChu);
            string chucVu = canBo.MaChucVuNavigation.TenChucVu;
            switch (chucVu)
            {
                case "Quản lý":
                    break;
                case "Cán bộ hồ sơ":
                    btnHeThong.Enabled = false;
                    btnViPham.Enabled = false;
                    btnCapGPLX.Enabled = false;
                    btnKyThi.Enabled = false;
                    break;
                case "Cán bộ sát hạch":
                    btnHeThong.Enabled = false;
                    btnViPham.Enabled = false;
                    btnCapGPLX.Enabled = false;                    
                    btnHoSo.Enabled = false;
                    break;
                case "Cán bộ Cấp GPLX":
                    btnHeThong.Enabled = false;
                    btnViPham.Enabled = false;                    
                    btnKyThi.Enabled = false;
                    btnHoSo.Enabled = false;
                    break;
                case "Cán bộ xử lý vi phạm":
                    btnHeThong.Enabled = false;                    
                    btnCapGPLX.Enabled = false;
                    btnKyThi.Enabled = false;
                    btnHoSo.Enabled = false;
                    break;               
                default:
                    btnHeThong.Enabled = false;
                    btnViPham.Enabled = false;
                    btnCapGPLX.Enabled = false;
                    btnKyThi.Enabled = false;
                    btnHoSo.Enabled = false;
                    break;
            }
        }

        public void LoadControl(UserControl uc)
        {
            this.panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(uc);
        }

        public void LoadInfo(CanBo canBo)
        {
            this.lbName.Text = canBo.HoTen;
            this.lbRole.Text = "Chức vụ: " + canBo.MaChucVuNavigation.TenChucVu;
            anhDaiDien.Image = Properties.Resources.Manager_Defaut;
            if (canBo.Anh3x4 != null)
            {                
                anhDaiDien.Image = (Image) Properties.Resources.ResourceManager.GetObject(canBo.Anh3x4);
            }
            else if (canBo.MaChucVuNavigation.TenChucVu == "Quản lý")
            {
                anhDaiDien.Image = Properties.Resources.Manager_Defaut;
            }
            else
            {
                anhDaiDien.Image = Properties.Resources.Employee_default;
            }
        }

        private void StartClock()
        {
            // Khởi tạo Timer
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 1000; // cập nhật mỗi 1 giây
            // Gán sự kiện Tick
            timerClock.Tick += (s, e) =>
            {
                this.lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
                this.lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            };
            timerClock.Start(); // Bắt đầu chạy
        }

        #endregion
        private ReaLTaiizor.Controls.CyberButton btnKyThi;
        private CyberButton btnCapGPLX;
        private CyberButton btnHoSo;
        private CyberButton btnTrangChu;
        private System.Windows.Forms.Panel panel1;
        private ParrotSlidingPanel parrotSlidingPanel1;
        private ParrotSlidingPanel parrotSlidingPanel2;
        private Label iconTrangChu;
        private CyberButton btnViPham;
        private CyberButton btnHeThong;
        private Label iconHoSo;
        private Label iconHeThong;
        private Label iconViPham;
        private Label iconCapGPLX;
        private Label iconKyThi;
        private System.Windows.Forms.Panel panelMain;
        private ParrotPictureBox anhDaiDien;
        private Label lbName;
        private Label lbRole;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private Label lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panel2;
        private Label lblDate;
        private PictureBox pictureBox2;
        private ParrotGradientPanel parrotGradientPanel1;
    }
}