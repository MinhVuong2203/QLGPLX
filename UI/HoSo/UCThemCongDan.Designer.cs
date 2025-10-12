using BLL;

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
            btnChonAnh3x4 = new Button();
            label12 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtSDT = new TextBox();
            label6 = new Label();
            txtDiaChi = new TextBox();
            label5 = new Label();
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
            groupBox1 = new GroupBox();
            btnChonAnhGiayKham = new Button();
            rtxTinhTrang = new RichTextBox();
            pictureBoxAnhGiayKham = new PictureBox();
            label11 = new Label();
            txtSoGiayKham = new TextBox();
            label10 = new Label();
            dtpNgayKham = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            btnSubmit = new ReaLTaiizor.Controls.SkyButton();
            panel3 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnReset = new ReaLTaiizor.Controls.SkyButton();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhDaiDien).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhGiayKham).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(btnChonAnh3x4);
            groupBox.Controls.Add(label12);
            groupBox.Controls.Add(txtEmail);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(txtSDT);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(txtDiaChi);
            groupBox.Controls.Add(label5);
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
            groupBox.Dock = DockStyle.Left;
            groupBox.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(764, 474);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = " THÔNG TIN CHUNG";
            // 
            // btnChonAnh3x4
            // 
            btnChonAnh3x4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChonAnh3x4.ForeColor = Color.DimGray;
            btnChonAnh3x4.Location = new Point(141, 363);
            btnChonAnh3x4.Name = "btnChonAnh3x4";
            btnChonAnh3x4.Size = new Size(68, 28);
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
            label12.Location = new Point(71, 366);
            label12.Name = "label12";
            label12.Size = new Size(67, 21);
            label12.TabIndex = 21;
            label12.Text = "Ảnh 3x4";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtEmail.ForeColor = Color.FromArgb(64, 0, 64);
            txtEmail.Location = new Point(365, 279);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(371, 30);
            txtEmail.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(271, 282);
            label7.Name = "label7";
            label7.Size = new Size(55, 23);
            label7.TabIndex = 19;
            label7.Text = "Email:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtSDT.ForeColor = Color.FromArgb(64, 0, 64);
            txtSDT.Location = new Point(549, 180);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(187, 30);
            txtSDT.TabIndex = 18;
            txtSDT.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(507, 183);
            label6.Name = "label6";
            label6.Size = new Size(44, 23);
            label6.TabIndex = 17;
            label6.Text = "SĐT:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtDiaChi.ForeColor = Color.FromArgb(64, 0, 64);
            txtDiaChi.Location = new Point(365, 227);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(371, 30);
            txtDiaChi.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(271, 230);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 15;
            label5.Text = "Địa chỉ:";
            // 
            // radioNam
            // 
            radioNam.AutoSize = true;
            radioNam.Depth = 0;
            radioNam.Location = new Point(360, 176);
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
            radioNu.Location = new Point(432, 176);
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
            label4.Location = new Point(271, 183);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 7;
            label4.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtpNgaySinh.CalendarForeColor = Color.FromArgb(64, 0, 64);
            dtpNgaySinh.CustomFormat = "dd-MM-YYYY";
            dtpNgaySinh.Location = new Point(365, 84);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(371, 30);
            dtpNgaySinh.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(271, 90);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh:";
            // 
            // pictureBoxAnhDaiDien
            // 
            pictureBoxAnhDaiDien.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAnhDaiDien.Location = new Point(21, 39);
            pictureBoxAnhDaiDien.Name = "pictureBoxAnhDaiDien";
            pictureBoxAnhDaiDien.Size = new Size(240, 320);
            pictureBoxAnhDaiDien.TabIndex = 4;
            pictureBoxAnhDaiDien.TabStop = false;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtTen.ForeColor = Color.FromArgb(64, 0, 64);
            txtTen.Location = new Point(365, 37);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(371, 30);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(271, 42);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên:";
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtCCCD.ForeColor = Color.FromArgb(64, 0, 64);
            txtCCCD.Location = new Point(365, 131);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(371, 30);
            txtCCCD.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(271, 134);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "CCCD:";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnChonAnhGiayKham);
            groupBox1.Controls.Add(rtxTinhTrang);
            groupBox1.Controls.Add(pictureBoxAnhGiayKham);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtSoGiayKham);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpNgayKham);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(783, 0);
            groupBox1.Margin = new Padding(3, 3, 30, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 474);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "SỨC KHỎE CÁ NHÂN";
            // 
            // btnChonAnhGiayKham
            // 
            btnChonAnhGiayKham.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChonAnhGiayKham.ForeColor = Color.DimGray;
            btnChonAnhGiayKham.Location = new Point(151, 277);
            btnChonAnhGiayKham.Name = "btnChonAnhGiayKham";
            btnChonAnhGiayKham.Size = new Size(92, 28);
            btnChonAnhGiayKham.TabIndex = 23;
            btnChonAnhGiayKham.Text = "Chọn ảnh";
            btnChonAnhGiayKham.UseVisualStyleBackColor = true;
            // 
            // rtxTinhTrang
            // 
            rtxTinhTrang.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtxTinhTrang.ForeColor = Color.FromArgb(64, 0, 64);
            rtxTinhTrang.Location = new Point(17, 68);
            rtxTinhTrang.Name = "rtxTinhTrang";
            rtxTinhTrang.Size = new Size(470, 93);
            rtxTinhTrang.TabIndex = 27;
            rtxTinhTrang.Text = "";
            // 
            // pictureBoxAnhGiayKham
            // 
            pictureBoxAnhGiayKham.BackColor = Color.White;
            pictureBoxAnhGiayKham.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAnhGiayKham.Location = new Point(34, 317);
            pictureBoxAnhGiayKham.Name = "pictureBoxAnhGiayKham";
            pictureBoxAnhGiayKham.Size = new Size(463, 126);
            pictureBoxAnhGiayKham.TabIndex = 26;
            pictureBoxAnhGiayKham.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(17, 282);
            label11.Name = "label11";
            label11.Size = new Size(130, 23);
            label11.TabIndex = 25;
            label11.Text = "Ảnh giấy khám:";
            // 
            // txtSoGiayKham
            // 
            txtSoGiayKham.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoGiayKham.ForeColor = Color.FromArgb(64, 0, 64);
            txtSoGiayKham.Location = new Point(141, 227);
            txtSoGiayKham.Name = "txtSoGiayKham";
            txtSoGiayKham.Size = new Size(274, 30);
            txtSoGiayKham.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(17, 230);
            label10.Name = "label10";
            label10.Size = new Size(118, 23);
            label10.TabIndex = 24;
            label10.Text = "Số giấy khám:";
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtpNgayKham.CalendarForeColor = Color.FromArgb(64, 0, 64);
            dtpNgayKham.Location = new Point(124, 180);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(291, 30);
            dtpNgayKham.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(17, 183);
            label9.Name = "label9";
            label9.Size = new Size(103, 23);
            label9.TabIndex = 23;
            label9.Text = "Ngày khám:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(17, 42);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
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
            btnSubmit.Location = new Point(631, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NormalBGColorA = Color.FromArgb(237, 175, 81);
            btnSubmit.NormalBGColorB = Color.FromArgb(226, 221, 154);
            btnSubmit.NormalBorderColorA = Color.FromArgb(181, 18, 27);
            btnSubmit.NormalBorderColorB = Color.FromArgb(12, 12, 12);
            btnSubmit.NormalBorderColorC = Color.FromArgb(150, 149, 149);
            btnSubmit.NormalBorderColorD = Color.FromArgb(150, 149, 149);
            btnSubmit.NormalForeColor = Color.Black;
            btnSubmit.NormalShadowForeColor = Color.White;
            btnSubmit.Size = new Size(622, 43);
            btnSubmit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Thêm mới";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(groupBox);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1300, 474);
            panel3.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnReset);
            flowLayoutPanel2.Controls.Add(btnSubmit);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 480);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1300, 222);
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
            btnReset.Location = new Point(3, 3);
            btnReset.Name = "btnReset";
            btnReset.NormalBGColorA = Color.FromArgb(237, 175, 81);
            btnReset.NormalBGColorB = Color.FromArgb(226, 221, 154);
            btnReset.NormalBorderColorA = Color.FromArgb(181, 18, 27);
            btnReset.NormalBorderColorB = Color.FromArgb(12, 12, 12);
            btnReset.NormalBorderColorC = Color.FromArgb(150, 149, 149);
            btnReset.NormalBorderColorD = Color.FromArgb(150, 149, 149);
            btnReset.NormalForeColor = Color.Black;
            btnReset.NormalShadowForeColor = Color.White;
            btnReset.Size = new Size(622, 43);
            btnReset.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnReset.TabIndex = 7;
            btnReset.Text = "Đặt lại";
            btnReset.Click += skyButton1_Click;
            // 
            // UCThemCongDan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel3);
            Name = "UCThemCongDan";
            Size = new Size(1300, 702);
            Load += UCThemCongDan_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhDaiDien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhGiayKham).EndInit();
            panel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtCCCD;
        private Label label2;
        private TextBox txtTen;
        private Label label3;
        private TextBox txtDiaChi;
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
        private TextBox txtSoGiayKham;
        private Label label10;
        private DateTimePicker dtpNgayKham;
        private Label label9;
        private Label label8;
        private PictureBox pictureBoxAnhGiayKham;
        private RichTextBox rtxTinhTrang;
        private PictureBox pictureBoxAnhDaiDien;
        private Button btnChonAnh3x4;
        private Label label12;
        private Button btnChonAnhGiayKham;
        private CongDanBLL congDanBLL = new CongDanBLL();
        private ReaLTaiizor.Controls.SkyButton btnSubmit;
        private FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.SkyButton btnReset;
    }
}
