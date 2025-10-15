using BLL;
using DAL;
using Newtonsoft.Json;
using UI.Models;

namespace UI.HoSo
{
    partial class UCThemCongDan
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
            groupBox = new GroupBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            btnChonAnh3x4 = new Button();
            label12 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtSDT = new TextBox();
            label6 = new Label();
            radioNam = new ReaLTaiizor.Controls.MaterialRadioButton();
            radioNu = new ReaLTaiizor.Controls.MaterialRadioButton();
            label4 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label3 = new Label();
            pictureBoxAnhDaiDien = new PictureBox();
            txtTen = new TextBox();
            label2 = new Label();
            txtCCCD = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label14 = new Label();
            cbTinh = new ComboBox();
            label5 = new Label();
            label15 = new Label();
            txtSoNha = new TextBox();
            cbPhuongXa = new ComboBox();
            label16 = new Label();
            groupBox1 = new GroupBox();
            btnChonAnhGiayKham = new Button();
            rtxTinhTrang = new RichTextBox();
            pictureBoxAnhGiayKham = new PictureBox();
            label11 = new Label();
            dtpNgayKham = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            btnSubmit = new ReaLTaiizor.Controls.SkyButton();
            panel3 = new Panel();
            label21 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnReset = new ReaLTaiizor.Controls.SkyButton();
            btnCapNhat = new ReaLTaiizor.Controls.SkyButton();
            panel1 = new Panel();
            label13 = new Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhDaiDien).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhGiayKham).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.PeachPuff;
            groupBox.Controls.Add(label20);
            groupBox.Controls.Add(label19);
            groupBox.Controls.Add(label18);
            groupBox.Controls.Add(label17);
            groupBox.Controls.Add(btnChonAnh3x4);
            groupBox.Controls.Add(label12);
            groupBox.Controls.Add(txtEmail);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(txtSDT);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(radioNam);
            groupBox.Controls.Add(radioNu);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(dtpNgaySinh);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(pictureBoxAnhDaiDien);
            groupBox.Controls.Add(txtTen);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(txtCCCD);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(groupBox2);
            groupBox.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(8, 119);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(1003, 650);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = " THÔNG TIN CHUNG";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Red;
            label20.Location = new Point(339, 244);
            label20.Name = "label20";
            label20.Size = new Size(23, 30);
            label20.TabIndex = 33;
            label20.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(339, 184);
            label19.Name = "label19";
            label19.Size = new Size(23, 30);
            label19.TabIndex = 32;
            label19.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Red;
            label18.Location = new Point(339, 120);
            label18.Name = "label18";
            label18.Size = new Size(23, 30);
            label18.TabIndex = 31;
            label18.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(339, 56);
            label17.Name = "label17";
            label17.Size = new Size(23, 30);
            label17.TabIndex = 30;
            label17.Text = "*";
            // 
            // btnChonAnh3x4
            // 
            btnChonAnh3x4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChonAnh3x4.ForeColor = Color.DimGray;
            btnChonAnh3x4.Location = new Point(179, 457);
            btnChonAnh3x4.Margin = new Padding(3, 4, 3, 4);
            btnChonAnh3x4.Name = "btnChonAnh3x4";
            btnChonAnh3x4.Size = new Size(78, 37);
            btnChonAnh3x4.TabIndex = 22;
            btnChonAnh3x4.Text = "Chọn";
            btnChonAnh3x4.UseVisualStyleBackColor = true;
            btnChonAnh3x4.Click += btnChonAnh3x4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(93, 461);
            label12.Name = "label12";
            label12.Size = new Size(84, 28);
            label12.TabIndex = 21;
            label12.Text = "Ảnh 3x4";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtEmail.ForeColor = Color.FromArgb(64, 0, 64);
            txtEmail.Location = new Point(693, 238);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 36);
            txtEmail.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(616, 241);
            label7.Name = "label7";
            label7.Size = new Size(71, 30);
            label7.TabIndex = 19;
            label7.Text = "Email:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtSDT.ForeColor = Color.FromArgb(64, 0, 64);
            txtSDT.Location = new Point(745, 114);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(234, 36);
            txtSDT.TabIndex = 18;
            txtSDT.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(676, 117);
            label6.Name = "label6";
            label6.Size = new Size(58, 30);
            label6.TabIndex = 17;
            label6.Text = "SĐT:";
            // 
            // radioNam
            // 
            radioNam.AutoSize = true;
            radioNam.Depth = 0;
            radioNam.Location = new Point(466, 241);
            radioNam.Margin = new Padding(0);
            radioNam.MouseLocation = new Point(-1, -1);
            radioNam.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radioNam.Name = "radioNam";
            radioNam.Ripple = true;
            radioNam.Size = new Size(69, 37);
            radioNam.TabIndex = 14;
            radioNam.TabStop = true;
            radioNam.Text = "Nam";
            radioNam.UseAccentColor = false;
            radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            radioNu.AutoSize = true;
            radioNu.Depth = 0;
            radioNu.Location = new Point(535, 241);
            radioNu.Margin = new Padding(0);
            radioNu.MouseLocation = new Point(-1, -1);
            radioNu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radioNu.Name = "radioNu";
            radioNu.Ripple = true;
            radioNu.Size = new Size(56, 37);
            radioNu.TabIndex = 13;
            radioNu.TabStop = true;
            radioNu.Text = "Nữ";
            radioNu.UseAccentColor = false;
            radioNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(355, 244);
            label4.Name = "label4";
            label4.Size = new Size(104, 30);
            label4.TabIndex = 7;
            label4.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtpNgaySinh.CalendarForeColor = Color.FromArgb(64, 0, 64);
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(476, 114);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(194, 36);
            dtpNgaySinh.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(357, 120);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh:";
            // 
            // pictureBoxAnhDaiDien
            // 
            pictureBoxAnhDaiDien.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAnhDaiDien.Location = new Point(30, 52);
            pictureBoxAnhDaiDien.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAnhDaiDien.Name = "pictureBoxAnhDaiDien";
            pictureBoxAnhDaiDien.Size = new Size(300, 400);
            pictureBoxAnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnhDaiDien.TabIndex = 4;
            pictureBoxAnhDaiDien.TabStop = false;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtTen.ForeColor = Color.FromArgb(64, 0, 64);
            txtTen.Location = new Point(476, 53);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(503, 36);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(355, 56);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên:";
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtCCCD.ForeColor = Color.FromArgb(64, 0, 64);
            txtCCCD.Location = new Point(476, 176);
            txtCCCD.Margin = new Padding(3, 4, 3, 4);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(194, 36);
            txtCCCD.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(359, 179);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 0;
            label1.Text = "CCCD:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(cbTinh);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtSoNha);
            groupBox2.Controls.Add(cbPhuongXa);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(355, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(622, 231);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Địa chỉ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(82, 6);
            label14.Name = "label14";
            label14.Size = new Size(121, 23);
            label14.TabIndex = 24;
            label14.Text = "(Sau xác nhập):";
            // 
            // cbTinh
            // 
            cbTinh.FormattingEnabled = true;
            cbTinh.Location = new Point(225, 50);
            cbTinh.Margin = new Padding(3, 4, 3, 4);
            cbTinh.Name = "cbTinh";
            cbTinh.Size = new Size(346, 38);
            cbTinh.TabIndex = 26;
            cbTinh.SelectedIndexChanged += cbTinh_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(61, 55);
            label5.Name = "label5";
            label5.Size = new Size(62, 30);
            label5.TabIndex = 15;
            label5.Text = "Tỉnh:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(61, 108);
            label15.Name = "label15";
            label15.Size = new Size(128, 30);
            label15.TabIndex = 25;
            label15.Text = "Phường/xã:";
            label15.Click += label15_Click;
            // 
            // txtSoNha
            // 
            txtSoNha.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtSoNha.ForeColor = Color.FromArgb(64, 0, 64);
            txtSoNha.Location = new Point(225, 157);
            txtSoNha.Margin = new Padding(3, 4, 3, 4);
            txtSoNha.Name = "txtSoNha";
            txtSoNha.Size = new Size(345, 36);
            txtSoNha.TabIndex = 29;
            // 
            // cbPhuongXa
            // 
            cbPhuongXa.FormattingEnabled = true;
            cbPhuongXa.Location = new Point(225, 105);
            cbPhuongXa.Margin = new Padding(3, 4, 3, 4);
            cbPhuongXa.Name = "cbPhuongXa";
            cbPhuongXa.Size = new Size(346, 38);
            cbPhuongXa.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(61, 157);
            label16.Name = "label16";
            label16.Size = new Size(161, 30);
            label16.TabIndex = 28;
            label16.Text = "Số nhà/đường:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(btnChonAnhGiayKham);
            groupBox1.Controls.Add(rtxTinhTrang);
            groupBox1.Controls.Add(pictureBoxAnhGiayKham);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dtpNgayKham);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1017, 119);
            groupBox1.Margin = new Padding(3, 4, 34, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(601, 650);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "SỨC KHỎE CÁ NHÂN";
            // 
            // btnChonAnhGiayKham
            // 
            btnChonAnhGiayKham.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChonAnhGiayKham.ForeColor = Color.DimGray;
            btnChonAnhGiayKham.Location = new Point(185, 339);
            btnChonAnhGiayKham.Margin = new Padding(3, 4, 3, 4);
            btnChonAnhGiayKham.Name = "btnChonAnhGiayKham";
            btnChonAnhGiayKham.Size = new Size(105, 37);
            btnChonAnhGiayKham.TabIndex = 23;
            btnChonAnhGiayKham.Text = "Chọn ảnh";
            btnChonAnhGiayKham.UseVisualStyleBackColor = true;
            btnChonAnhGiayKham.Click += btnChonAnhGiayKham_Click;
            // 
            // rtxTinhTrang
            // 
            rtxTinhTrang.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtxTinhTrang.ForeColor = Color.FromArgb(64, 0, 64);
            rtxTinhTrang.Location = new Point(19, 82);
            rtxTinhTrang.Margin = new Padding(3, 4, 3, 4);
            rtxTinhTrang.Name = "rtxTinhTrang";
            rtxTinhTrang.Size = new Size(537, 192);
            rtxTinhTrang.TabIndex = 27;
            rtxTinhTrang.Text = "";
            // 
            // pictureBoxAnhGiayKham
            // 
            pictureBoxAnhGiayKham.BackColor = Color.White;
            pictureBoxAnhGiayKham.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAnhGiayKham.Location = new Point(112, 391);
            pictureBoxAnhGiayKham.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAnhGiayKham.Name = "pictureBoxAnhGiayKham";
            pictureBoxAnhGiayKham.Size = new Size(383, 233);
            pictureBoxAnhGiayKham.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnhGiayKham.TabIndex = 26;
            pictureBoxAnhGiayKham.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(19, 344);
            label11.Name = "label11";
            label11.Size = new Size(167, 30);
            label11.TabIndex = 25;
            label11.Text = "Ảnh giấy khám:";
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtpNgayKham.CalendarForeColor = Color.FromArgb(64, 0, 64);
            dtpNgayKham.CustomFormat = "dd-MM-yyyy";
            dtpNgayKham.Format = DateTimePickerFormat.Custom;
            dtpNgayKham.Location = new Point(155, 287);
            dtpNgayKham.Margin = new Padding(3, 4, 3, 4);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(157, 36);
            dtpNgayKham.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(19, 291);
            label9.Name = "label9";
            label9.Size = new Size(131, 30);
            label9.TabIndex = 23;
            label9.Text = "Ngày khám:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(19, 47);
            label8.Name = "label8";
            label8.Size = new Size(121, 30);
            label8.TabIndex = 21;
            label8.Text = "Tình trạng:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.DownBGColorA = Color.FromArgb(237, 175, 81);
            btnSubmit.DownBGColorB = Color.FromArgb(12, 12, 12);
            btnSubmit.DownBorderColorA = Color.FromArgb(181, 18, 27);
            btnSubmit.DownBorderColorB = Color.FromArgb(12, 12, 12);
            btnSubmit.DownBorderColorC = Color.FromArgb(150, 149, 149);
            btnSubmit.DownBorderColorD = Color.FromArgb(150, 149, 149);
            btnSubmit.DownForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSubmit.DownShadowForeColor = Color.White;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.HoverBGColorA = Color.FromArgb(181, 18, 27);
            btnSubmit.HoverBGColorB = Color.FromArgb(237, 175, 81);
            btnSubmit.HoverBorderColorA = Color.FromArgb(181, 18, 27);
            btnSubmit.HoverBorderColorB = Color.FromArgb(12, 12, 12);
            btnSubmit.HoverBorderColorC = Color.FromArgb(150, 149, 149);
            btnSubmit.HoverBorderColorD = Color.FromArgb(150, 149, 149);
            btnSubmit.HoverForeColor = Color.White;
            btnSubmit.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnSubmit.Location = new Point(540, 4);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NormalBGColorA = Color.FromArgb(237, 175, 81);
            btnSubmit.NormalBGColorB = Color.FromArgb(226, 221, 154);
            btnSubmit.NormalBorderColorA = Color.FromArgb(181, 18, 27);
            btnSubmit.NormalBorderColorB = Color.FromArgb(12, 12, 12);
            btnSubmit.NormalBorderColorC = Color.FromArgb(150, 149, 149);
            btnSubmit.NormalBorderColorD = Color.FromArgb(150, 149, 149);
            btnSubmit.NormalForeColor = Color.Black;
            btnSubmit.NormalShadowForeColor = Color.White;
            btnSubmit.Size = new Size(540, 57);
            btnSubmit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Thêm mới";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label21);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(groupBox);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1630, 936);
            panel3.TabIndex = 4;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(1040, 73);
            label21.Name = "label21";
            label21.Size = new Size(95, 28);
            label21.TabIndex = 4;
            label21.Text = "Tìm kiếm:";
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.search;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(1419, 64);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(53, 41);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(64, 0, 64);
            txtSearch.Location = new Point(1137, 67);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(275, 34);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "Nhập CCCD:";
            txtSearch.GotFocus += TxtCCCD_GotFocus;
            txtSearch.LostFocus += TxtCCCD_LostFocus;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(btnReset);
            flowLayoutPanel2.Controls.Add(btnSubmit);
            flowLayoutPanel2.Controls.Add(btnCapNhat);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 853);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1630, 83);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.DownBGColorA = Color.FromArgb(237, 175, 81);
            btnReset.DownBGColorB = Color.FromArgb(12, 12, 12);
            btnReset.DownBorderColorA = Color.FromArgb(181, 18, 27);
            btnReset.DownBorderColorB = Color.FromArgb(12, 12, 12);
            btnReset.DownBorderColorC = Color.FromArgb(150, 149, 149);
            btnReset.DownBorderColorD = Color.FromArgb(150, 149, 149);
            btnReset.DownForeColor = Color.FromArgb(200, 0, 0, 0);
            btnReset.DownShadowForeColor = Color.White;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.HoverBGColorA = Color.FromArgb(181, 18, 27);
            btnReset.HoverBGColorB = Color.FromArgb(237, 175, 81);
            btnReset.HoverBorderColorA = Color.FromArgb(181, 18, 27);
            btnReset.HoverBorderColorB = Color.FromArgb(12, 12, 12);
            btnReset.HoverBorderColorC = Color.FromArgb(150, 149, 149);
            btnReset.HoverBorderColorD = Color.FromArgb(150, 149, 149);
            btnReset.HoverForeColor = Color.White;
            btnReset.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnReset.Location = new Point(3, 4);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.NormalBGColorA = Color.FromArgb(237, 175, 81);
            btnReset.NormalBGColorB = Color.FromArgb(226, 221, 154);
            btnReset.NormalBorderColorA = Color.FromArgb(181, 18, 27);
            btnReset.NormalBorderColorB = Color.FromArgb(12, 12, 12);
            btnReset.NormalBorderColorC = Color.FromArgb(150, 149, 149);
            btnReset.NormalBorderColorD = Color.FromArgb(150, 149, 149);
            btnReset.NormalForeColor = Color.Black;
            btnReset.NormalShadowForeColor = Color.White;
            btnReset.Size = new Size(531, 57);
            btnReset.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnReset.TabIndex = 7;
            btnReset.Text = "Đặt lại";
            btnReset.Click += skyButton1_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Transparent;
            btnCapNhat.DownBGColorA = Color.FromArgb(237, 175, 81);
            btnCapNhat.DownBGColorB = Color.FromArgb(12, 12, 12);
            btnCapNhat.DownBorderColorA = Color.FromArgb(181, 18, 27);
            btnCapNhat.DownBorderColorB = Color.FromArgb(12, 12, 12);
            btnCapNhat.DownBorderColorC = Color.FromArgb(150, 149, 149);
            btnCapNhat.DownBorderColorD = Color.FromArgb(150, 149, 149);
            btnCapNhat.DownForeColor = Color.FromArgb(200, 0, 0, 0);
            btnCapNhat.DownShadowForeColor = Color.White;
            btnCapNhat.Enabled = false;
            btnCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.Black;
            btnCapNhat.HoverBGColorA = Color.FromArgb(181, 18, 27);
            btnCapNhat.HoverBGColorB = Color.FromArgb(237, 175, 81);
            btnCapNhat.HoverBorderColorA = Color.FromArgb(181, 18, 27);
            btnCapNhat.HoverBorderColorB = Color.FromArgb(12, 12, 12);
            btnCapNhat.HoverBorderColorC = Color.FromArgb(150, 149, 149);
            btnCapNhat.HoverBorderColorD = Color.FromArgb(150, 149, 149);
            btnCapNhat.HoverForeColor = Color.White;
            btnCapNhat.HoverShadowForeColor = Color.FromArgb(200, 0, 0, 0);
            btnCapNhat.Location = new Point(1086, 4);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.NormalBGColorA = Color.FromArgb(237, 175, 81);
            btnCapNhat.NormalBGColorB = Color.FromArgb(226, 221, 154);
            btnCapNhat.NormalBorderColorA = Color.FromArgb(181, 18, 27);
            btnCapNhat.NormalBorderColorB = Color.FromArgb(12, 12, 12);
            btnCapNhat.NormalBorderColorC = Color.FromArgb(150, 149, 149);
            btnCapNhat.NormalBorderColorD = Color.FromArgb(150, 149, 149);
            btnCapNhat.NormalForeColor = Color.Black;
            btnCapNhat.NormalShadowForeColor = Color.White;
            btnCapNhat.Size = new Size(531, 57);
            btnCapNhat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCapNhat.TabIndex = 8;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1630, 55);
            panel1.TabIndex = 6;
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(255, 128, 128);
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(1630, 55);
            label13.TabIndex = 0;
            label13.Text = "Thêm - cập nhật - tra cứu công dân";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UCThemCongDan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCThemCongDan";
            Size = new Size(1630, 936);
            Load += UCThemCongDan_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhDaiDien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhGiayKham).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void LoadDiaChiFromJson()
        {
            string jsonPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "SauXacNhap.json");
            string json = File.ReadAllText(jsonPath);
            diaChiList = JsonConvert.DeserializeObject<List<Tinh>>(json);
        }

        private void LoadTinh()
        {
            var tinhs = diaChiList.Select(x => x.tentinhmoi).ToList();
            this.cbTinh.DataSource = tinhs;
        }

        private void setDefaltInfo()
        {
            this.txtTen.Text = "";
            this.txtCCCD.Text = "";
            this.txtSoNha.Text = "";
            this.cbTinh.SelectedIndex = -1;
            this.cbPhuongXa.DataSource = null;
            this.txtEmail.Text = "";
            this.radioNam.Checked = false;
            this.radioNu.Checked = false;
            this.txtEmail.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.dtpNgayKham.Value = DateTime.Now;
            this.rtxTinhTrang.Text = "";
            this.txtSDT.Text = "";
            this.pictureBoxAnhDaiDien.Image = null;
            this.pictureBoxAnhGiayKham.Image = null;
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtCCCD;
        private Label label2;
        private TextBox txtTen;
        private Label label3;
        private GroupBox groupBox;
        private Label label4;
        private DateTimePicker dtpNgaySinh;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.CyberRadioButton cyberRadioButton1;
        private ReaLTaiizor.Controls.CrownRadioButton crownRadioButton1;
        private ReaLTaiizor.Controls.AloneRadioButton aloneRadioButton1;
        private ReaLTaiizor.Controls.AirRadioButton airRadioButton1;
        private ReaLTaiizor.Controls.MaterialRadioButton materialRadioButton1;
        private ReaLTaiizor.Controls.CyberRadioButton cyberRadioButton2;
        private ReaLTaiizor.Controls.MaterialRadioButton materialRadioButton2;
        private ReaLTaiizor.Controls.MaterialRadioButton radioNam;
        private ReaLTaiizor.Controls.MaterialRadioButton radioNu;
        private Label label5;
        private TextBox txtSDT;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private Panel panel3;
        private Label label11;
        private DateTimePicker dtpNgayKham;
        private Label label9;
        private Label label8;
        private PictureBox pictureBoxAnhGiayKham;
        private RichTextBox rtxTinhTrang;
        private PictureBox pictureBoxAnhDaiDien;
        private Button btnChonAnh3x4;
        private Label label12;
        private Button btnChonAnhGiayKham;
        private CongDanBLL congDanBLL;
        private ReaLTaiizor.Controls.SkyButton btnSubmit;
        private FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.SkyButton btnReset;
        private Panel panel1;
        private Label label13;
        private ReaLTaiizor.Controls.SkyButton btnCapNhat;
        private string duongDanAnh3x4 = "";
        private string duongDanAnhGiayKham = "";
        private Label label15;
        private Label label14;
        private Label label10;
        private List<Tinh> diaChiList = new List<Tinh>();
        private ComboBox cbPhuongXa;
        private ComboBox cbTinh;
        private TextBox txtSoNha;
        private Label label16;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label21;
        private GroupBox groupBox2;
    }
}
