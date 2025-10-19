using DAL;

namespace UI.CapGPLX
{
    partial class UCXetDuyetCapGPLX
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label13 = new Label();
            label1 = new Label();
            cboMaHang = new ComboBox();
            cboCongDan = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelMatTruoc = new ReaLTaiizor.Controls.ParrotGradientPanel();
            lbDiaChiPhuongTinh = new Label();
            label22 = new Label();
            LbHang = new Label();
            lbDiaChi = new Label();
            label24 = new Label();
            lbNgaySinh = new Label();
            LbTen = new Label();
            lbSo = new Label();
            label20 = new Label();
            label19 = new Label();
            lbNgayThangNam = new Label();
            label12 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label14 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            pictureBoxAnh = new PictureBox();
            panelMatSau = new ReaLTaiizor.Controls.ParrotGradientPanel();
            pictureBox1 = new PictureBox();
            lbNgay = new Label();
            label26 = new Label();
            label27 = new Label();
            lbMota = new Label();
            label25 = new Label();
            label23 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnDuyet = new Button();
            panelMatTruoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnh).BeginInit();
            panelMatSau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(255, 192, 128);
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(1630, 29);
            label13.TabIndex = 10;
            label13.Text = "Cấp GPLX cho thí sinh";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(43, 60);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 11;
            label1.Text = "Chọn mã hạng:";
            // 
            // cboMaHang
            // 
            cboMaHang.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Items.AddRange(new object[] { "", "A1", "A" });
            cboMaHang.Location = new Point(229, 59);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(243, 38);
            cboMaHang.TabIndex = 12;
            cboMaHang.SelectedIndexChanged += cboMaHang_SelectedIndexChanged;
            // 
            // cboCongDan
            // 
            cboCongDan.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCongDan.FormattingEnabled = true;
            cboCongDan.Items.AddRange(new object[] { "", "A1", "A" });
            cboCongDan.Location = new Point(720, 61);
            cboCongDan.Name = "cboCongDan";
            cboCongDan.Size = new Size(676, 38);
            cboCongDan.TabIndex = 14;
            cboCongDan.SelectedIndexChanged += cboCongDan_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(534, 62);
            label2.Name = "label2";
            label2.Size = new Size(174, 31);
            label2.TabIndex = 13;
            label2.Text = "Chọn công dân:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(90, 170);
            label3.Name = "label3";
            label3.Size = new Size(121, 31);
            label3.TabIndex = 15;
            label3.Text = "Mặt trước:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(817, 170);
            label4.Name = "label4";
            label4.Size = new Size(101, 31);
            label4.TabIndex = 16;
            label4.Text = "Mặt sau:";
            // 
            // panelMatTruoc
            // 
            panelMatTruoc.BottomLeft = Color.FromArgb(226, 221, 154);
            panelMatTruoc.BottomRight = Color.FromArgb(237, 175, 81);
            panelMatTruoc.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            panelMatTruoc.Controls.Add(lbDiaChiPhuongTinh);
            panelMatTruoc.Controls.Add(label22);
            panelMatTruoc.Controls.Add(LbHang);
            panelMatTruoc.Controls.Add(lbDiaChi);
            panelMatTruoc.Controls.Add(label24);
            panelMatTruoc.Controls.Add(lbNgaySinh);
            panelMatTruoc.Controls.Add(LbTen);
            panelMatTruoc.Controls.Add(lbSo);
            panelMatTruoc.Controls.Add(label20);
            panelMatTruoc.Controls.Add(label19);
            panelMatTruoc.Controls.Add(label12);
            panelMatTruoc.Controls.Add(label9);
            panelMatTruoc.Controls.Add(label7);
            panelMatTruoc.Controls.Add(label6);
            panelMatTruoc.Controls.Add(label5);
            panelMatTruoc.Controls.Add(label8);
            panelMatTruoc.Controls.Add(label10);
            panelMatTruoc.Controls.Add(label11);
            panelMatTruoc.Controls.Add(label14);
            panelMatTruoc.Controls.Add(label18);
            panelMatTruoc.Controls.Add(label17);
            panelMatTruoc.Controls.Add(label16);
            panelMatTruoc.Controls.Add(label15);
            panelMatTruoc.Controls.Add(pictureBoxAnh);
            panelMatTruoc.Controls.Add(lbNgayThangNam);
            panelMatTruoc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelMatTruoc.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            panelMatTruoc.Location = new Point(90, 235);
            panelMatTruoc.Name = "panelMatTruoc";
            panelMatTruoc.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            panelMatTruoc.PrimerColor = Color.White;
            panelMatTruoc.Size = new Size(688, 432);
            panelMatTruoc.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            panelMatTruoc.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            panelMatTruoc.TabIndex = 17;
            panelMatTruoc.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            panelMatTruoc.TopLeft = Color.Yellow;
            panelMatTruoc.TopRight = Color.FromArgb(192, 64, 0);
            // 
            // lbDiaChiPhuongTinh
            // 
            lbDiaChiPhuongTinh.AutoSize = true;
            lbDiaChiPhuongTinh.BackColor = Color.Transparent;
            lbDiaChiPhuongTinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDiaChiPhuongTinh.ForeColor = SystemColors.ActiveCaptionText;
            lbDiaChiPhuongTinh.Location = new Point(259, 260);
            lbDiaChiPhuongTinh.Name = "lbDiaChiPhuongTinh";
            lbDiaChiPhuongTinh.Size = new Size(100, 28);
            lbDiaChiPhuongTinh.TabIndex = 24;
            lbDiaChiPhuongTinh.Text = "___________";
            lbDiaChiPhuongTinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ActiveCaptionText;
            label22.Location = new Point(196, 395);
            label22.Name = "label22";
            label22.Size = new Size(154, 28);
            label22.TabIndex = 23;
            label22.Text = "Không thời hạn";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbHang
            // 
            LbHang.AutoSize = true;
            LbHang.BackColor = Color.Transparent;
            LbHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHang.ForeColor = SystemColors.ActiveCaptionText;
            LbHang.Location = new Point(125, 362);
            LbHang.Name = "LbHang";
            LbHang.Size = new Size(36, 28);
            LbHang.TabIndex = 22;
            LbHang.Text = "___";
            LbHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.BackColor = Color.Transparent;
            lbDiaChi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDiaChi.ForeColor = SystemColors.ActiveCaptionText;
            lbDiaChi.Location = new Point(396, 229);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(100, 28);
            lbDiaChi.TabIndex = 20;
            lbDiaChi.Text = "___________";
            lbDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ActiveCaptionText;
            label24.Location = new Point(420, 194);
            label24.Name = "label24";
            label24.Size = new Size(250, 28);
            label24.TabIndex = 19;
            label24.Text = "VIỆT NAM";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.BackColor = Color.Transparent;
            lbNgaySinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNgaySinh.ForeColor = SystemColors.ActiveCaptionText;
            lbNgaySinh.Location = new Point(434, 159);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(250, 28);
            lbNgaySinh.TabIndex = 18;
            lbNgaySinh.Text = "___________";
            lbNgaySinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbTen
            // 
            LbTen.BackColor = Color.Transparent;
            LbTen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTen.ForeColor = SystemColors.ActiveCaptionText;
            LbTen.Location = new Point(376, 127);
            LbTen.Name = "LbTen";
            LbTen.Size = new Size(308, 28);
            LbTen.TabIndex = 17;
            LbTen.Text = "___________";
            LbTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSo
            // 
            lbSo.AutoSize = true;
            lbSo.BackColor = Color.Transparent;
            lbSo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSo.ForeColor = Color.FromArgb(192, 0, 0);
            lbSo.Location = new Point(396, 90);
            lbSo.Name = "lbSo";
            lbSo.Size = new Size(61, 25);
            lbSo.TabIndex = 16;
            lbSo.Text = "_______";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(192, 0, 0);
            label20.Location = new Point(328, 90);
            label20.Name = "label20";
            label20.Size = new Size(71, 25);
            label20.TabIndex = 15;
            label20.Text = "Số/No:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(15, 397);
            label19.Name = "label19";
            label19.Size = new Size(185, 25);
            label19.TabIndex = 14;
            label19.Text = "Có giá trị đến/Expires:";
            // 
            // lbNgayThangNam
            // 
            lbNgayThangNam.BackColor = Color.Transparent;
            lbNgayThangNam.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNgayThangNam.ForeColor = SystemColors.ActiveCaptionText;
            lbNgayThangNam.Location = new Point(196, 305);
            lbNgayThangNam.Name = "lbNgayThangNam";
            lbNgayThangNam.Size = new Size(474, 28);
            lbNgayThangNam.TabIndex = 10;
            lbNgayThangNam.Text = "An Giang, ngày/date__tháng/month__năm/year__";
            lbNgayThangNam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(254, 59);
            label12.Name = "label12";
            label12.Size = new Size(416, 31);
            label12.TabIndex = 8;
            label12.Text = "GIẤY PHÉP LÁI XE/ DRIVER'S LICENSE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(266, 3);
            label9.Name = "label9";
            label9.Size = new Size(404, 28);
            label9.TabIndex = 5;
            label9.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(85, 29);
            label7.Name = "label7";
            label7.Size = new Size(54, 28);
            label7.TabIndex = 3;
            label7.Text = "MOT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(67, 1);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 2;
            label6.Text = "BỘ GTVT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(15, 360);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 1;
            label5.Text = "Hạng/Class:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(81, 40);
            label8.Name = "label8";
            label8.Size = new Size(60, 28);
            label8.TabIndex = 4;
            label8.Text = "------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(327, 25);
            label10.Name = "label10";
            label10.Size = new Size(273, 28);
            label10.TabIndex = 6;
            label10.Text = "Độc lập - Tự do - Hạnh phúc";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(321, 39);
            label11.Name = "label11";
            label11.Size = new Size(284, 28);
            label11.TabIndex = 7;
            label11.Text = "----------------------------------";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(211, 127);
            label14.Name = "label14";
            label14.Size = new Size(167, 28);
            label14.TabIndex = 9;
            label14.Text = "Họ tên/Full name:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(211, 159);
            label18.Name = "label18";
            label18.Size = new Size(221, 28);
            label18.TabIndex = 13;
            label18.Text = "Ngày sinh/Date of Birth:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(211, 194);
            label17.Name = "label17";
            label17.Size = new Size(205, 28);
            label17.TabIndex = 12;
            label17.Text = "Quốc tịch/Nationality:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(211, 229);
            label16.Name = "label16";
            label16.Size = new Size(182, 28);
            label16.TabIndex = 11;
            label16.Text = "Nơi cư trú/Address:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(420, 331);
            label15.Name = "label15";
            label15.Size = new Size(145, 25);
            label15.TabIndex = 21;
            label15.Text = "PHÓ GIÁM ĐỐC";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAnh
            // 
            pictureBoxAnh.Location = new Point(7, 93);
            pictureBoxAnh.Name = "pictureBoxAnh";
            pictureBoxAnh.Size = new Size(200, 266);
            pictureBoxAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAnh.TabIndex = 0;
            pictureBoxAnh.TabStop = false;
            // 
            // panelMatSau
            // 
            panelMatSau.BottomLeft = Color.FromArgb(226, 221, 154);
            panelMatSau.BottomRight = Color.FromArgb(237, 175, 81);
            panelMatSau.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            panelMatSau.Controls.Add(pictureBox1);
            panelMatSau.Controls.Add(lbNgay);
            panelMatSau.Controls.Add(label26);
            panelMatSau.Controls.Add(label27);
            panelMatSau.Controls.Add(lbMota);
            panelMatSau.Controls.Add(label25);
            panelMatSau.Controls.Add(label23);
            panelMatSau.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            panelMatSau.Location = new Point(826, 235);
            panelMatSau.Name = "panelMatSau";
            panelMatSau.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            panelMatSau.PrimerColor = Color.White;
            panelMatSau.Size = new Size(688, 432);
            panelMatSau.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            panelMatSau.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            panelMatSau.TabIndex = 18;
            panelMatSau.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            panelMatSau.TopLeft = Color.Yellow;
            panelMatSau.TopRight = Color.FromArgb(192, 64, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.qr1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(6, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // lbNgay
            // 
            lbNgay.BackColor = Color.Transparent;
            lbNgay.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNgay.ForeColor = SystemColors.ActiveCaptionText;
            lbNgay.Location = new Point(555, 65);
            lbNgay.Name = "lbNgay";
            lbNgay.Size = new Size(129, 25);
            lbNgay.TabIndex = 24;
            lbNgay.Text = "Ngày";
            lbNgay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ActiveCaptionText;
            label26.Location = new Point(563, 28);
            label26.Name = "label26";
            label26.Size = new Size(119, 22);
            label26.TabIndex = 28;
            label26.Text = "Beginning date";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Red;
            label27.Location = new Point(553, 5);
            label27.Name = "label27";
            label27.Size = new Size(140, 22);
            label27.TabIndex = 10;
            label27.Text = "Ngày trúng tuyển";
            // 
            // lbMota
            // 
            lbMota.AutoSize = true;
            lbMota.BackColor = Color.Transparent;
            lbMota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMota.ForeColor = SystemColors.ActiveCaptionText;
            lbMota.Location = new Point(6, 68);
            lbMota.Name = "lbMota";
            lbMota.Size = new Size(65, 28);
            lbMota.TabIndex = 26;
            lbMota.Text = "Mô tả";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.ActiveCaptionText;
            label25.Location = new Point(111, 29);
            label25.Name = "label25";
            label25.Size = new Size(322, 25);
            label25.TabIndex = 25;
            label25.Text = "CLASSIFICATION OF MOTOR VEHICLES";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(18, 3);
            label23.Name = "label23";
            label23.Size = new Size(464, 25);
            label23.TabIndex = 24;
            label23.Text = "CÁC LOẠI XE CƠ GIỚI ĐƯỜNG BỘ ĐƯỢC ĐIỀU KHIỂN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(1381, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 432);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(826, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(688, 1);
            panel2.TabIndex = 27;
            // 
            // btnDuyet
            // 
            btnDuyet.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDuyet.ForeColor = SystemColors.ActiveCaptionText;
            btnDuyet.Location = new Point(1358, 726);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(187, 46);
            btnDuyet.TabIndex = 28;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = true;
            btnDuyet.Click += btnDuyet_Click;
            // 
            // UCXetDuyetCapGPLX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDuyet);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMatSau);
            Controls.Add(panelMatTruoc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboCongDan);
            Controls.Add(label2);
            Controls.Add(cboMaHang);
            Controls.Add(label1);
            Controls.Add(label13);
            Name = "UCXetDuyetCapGPLX";
            Size = new Size(1630, 800);
            panelMatTruoc.ResumeLayout(false);
            panelMatTruoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnh).EndInit();
            panelMatSau.ResumeLayout(false);
            panelMatSau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private void ClearDisplay()
        {
            LbTen.Text = "___________";
            lbNgaySinh.Text = "___________";
            lbDiaChi.Text = "___________";
            LbHang.Text = "___";
            lbSo.Text = "_______";
            lbNgayThangNam.Text = "An Giang, ngày/date__tháng/month__năm/year__";
            pictureBoxAnh.Image = null;
            lbMota.Text = "Mô tả";
            lbNgay.Text = "Ngày";
        }
        #endregion

        private void LoadcomboBoxCongDan(string maHang)
        {
            this.cboCongDan.SelectedIndex = -1;
            List<GiayPhep> list = _giayPhepDAL.GetByTrangThaiAndMahang(maHang, "Chờ xét duyệt");
            string[] data = new string[list.Count];
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    data[i] = list[i].MaCongDan.ToString() + " - " + list[i].MaCongDanNavigation.HoTen.ToString();
                }
                this.cboCongDan.DataSource = data;
            }
        }
        private Label label13;
        private Label label1;
        private ComboBox cboMaHang;
        private ComboBox cboCongDan;
        private Label label2;
        private Label label3;
        private Label label4;
        private ReaLTaiizor.Controls.ParrotGradientPanel panelMatTruoc;
        private Label label5;
        private PictureBox pictureBoxAnh;
        private ReaLTaiizor.Controls.ParrotGradientPanel panelMatSau;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label lbNgayThangNam;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label24;
        private Label lbNgaySinh;
        private Label LbTen;
        private Label lbSo;
        private Label label20;
        private Label label19;
        private Label label22;
        private Label LbHang;
        private Label lbDiaChi;
        private Label label15;
        private Label label25;
        private Label label23;
        private Panel panel2;
        private Panel panel1;
        private Label label26;
        private Label label27;
        private Label lbMota;
        private Label lbNgay;
        private PictureBox pictureBox1;
        private Button btnDuyet;
        private GiayPhepDAl _giayPhepDAL = new GiayPhepDAl();
        private Label lbDiaChiPhuongTinh;
    }
}
