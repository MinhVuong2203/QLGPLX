using BLL;
using DAL;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace UI.HoSo
{
    partial class UCThemHoSo
    {
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


        private void InitializeComponent()
        {
            pnlMain = new Panel();
            groupBox = new GroupBox();
            txtSDT = new TextBox();
            label1 = new Label();
            txtGioiTinh = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label16 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label3 = new Label();
            pictureBoxAnhDaiDien = new PictureBox();
            txtTen = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            lblCongDan = new Label();
            cboCongDan = new ComboBox();
            txtGhiChu = new RichTextBox();
            lblHang = new Label();
            lblGhiChu = new Label();
            dtpNgayNop = new DateTimePicker();
            lblNgayNop = new Label();
            label13 = new Label();
            pnlButton = new Panel();
            btnLuu = new Button();
            btnHuy = new Button();
            pnlMain.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhDaiDien).BeginInit();
            groupBox1.SuspendLayout();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(groupBox);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(label13);
            pnlMain.Controls.Add(pnlButton);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1630, 800);
            pnlMain.TabIndex = 0;
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.PeachPuff;
            groupBox.Controls.Add(txtSDT);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(txtGioiTinh);
            groupBox.Controls.Add(txtEmail);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(txtDiaChi);
            groupBox.Controls.Add(label16);
            groupBox.Controls.Add(dtpNgaySinh);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(pictureBoxAnhDaiDien);
            groupBox.Controls.Add(txtTen);
            groupBox.Controls.Add(label2);
            groupBox.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(794, 65);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(800, 538);
            groupBox.TabIndex = 4;
            groupBox.TabStop = false;
            groupBox.Text = " Thông tin chi tiết";
            // 
            // txtSDT
            // 
            txtSDT.Enabled = false;
            txtSDT.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtSDT.ForeColor = Color.FromArgb(64, 0, 64);
            txtSDT.Location = new Point(445, 137);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(240, 36);
            txtSDT.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(325, 138);
            label1.Name = "label1";
            label1.Size = new Size(58, 30);
            label1.TabIndex = 31;
            label1.Text = "SĐT:";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Enabled = false;
            txtGioiTinh.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtGioiTinh.ForeColor = Color.FromArgb(64, 0, 64);
            txtGioiTinh.Location = new Point(445, 266);
            txtGioiTinh.Margin = new Padding(3, 4, 3, 4);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(240, 36);
            txtGioiTinh.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtEmail.ForeColor = Color.FromArgb(64, 0, 64);
            txtEmail.Location = new Point(438, 341);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 36);
            txtEmail.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(325, 341);
            label7.Name = "label7";
            label7.Size = new Size(71, 30);
            label7.TabIndex = 19;
            label7.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(325, 269);
            label4.Name = "label4";
            label4.Size = new Size(104, 30);
            label4.TabIndex = 7;
            label4.Text = "Giới tính:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Enabled = false;
            txtDiaChi.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtDiaChi.ForeColor = Color.FromArgb(64, 0, 64);
            txtDiaChi.Location = new Point(124, 407);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(656, 36);
            txtDiaChi.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(32, 407);
            label16.Name = "label16";
            label16.Size = new Size(86, 30);
            label16.TabIndex = 28;
            label16.Text = "Địa chỉ:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtpNgaySinh.CalendarForeColor = Color.FromArgb(64, 0, 64);
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            dtpNgaySinh.Enabled = false;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(445, 201);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(240, 36);
            dtpNgaySinh.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(322, 206);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh:";
            // 
            // pictureBoxAnhDaiDien
            // 
            pictureBoxAnhDaiDien.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAnhDaiDien.Location = new Point(31, 55);
            pictureBoxAnhDaiDien.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAnhDaiDien.Name = "pictureBoxAnhDaiDien";
            pictureBoxAnhDaiDien.Size = new Size(240, 320);
            pictureBoxAnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnhDaiDien.TabIndex = 4;
            pictureBoxAnhDaiDien.TabStop = false;
            // 
            // txtTen
            // 
            txtTen.Enabled = false;
            txtTen.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            txtTen.ForeColor = Color.FromArgb(64, 0, 64);
            txtTen.Location = new Point(445, 76);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(335, 36);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(325, 79);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lblCongDan);
            groupBox1.Controls.Add(cboCongDan);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(lblHang);
            groupBox1.Controls.Add(lblGhiChu);
            groupBox1.Controls.Add(dtpNgayNop);
            groupBox1.Controls.Add(lblNgayNop);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(43, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 538);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hồ sơ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A1", "A" });
            comboBox1.Location = new Point(531, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 39);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblCongDan
            // 
            lblCongDan.AutoSize = true;
            lblCongDan.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            lblCongDan.ForeColor = Color.FromArgb(52, 73, 94);
            lblCongDan.Location = new Point(32, 129);
            lblCongDan.Name = "lblCongDan";
            lblCongDan.Size = new Size(77, 31);
            lblCongDan.TabIndex = 0;
            lblCongDan.Text = "CCCD:";
            // 
            // cboCongDan
            // 
            cboCongDan.BackColor = Color.Gainsboro;
            cboCongDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCongDan.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCongDan.ForeColor = Color.FromArgb(52, 73, 94);
            cboCongDan.Location = new Point(162, 126);
            cboCongDan.Name = "cboCongDan";
            cboCongDan.Size = new Size(526, 38);
            cboCongDan.TabIndex = 1;
            cboCongDan.SelectedIndexChanged += cboCongDan_SelectedIndexChanged;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BackColor = Color.White;
            txtGhiChu.BorderStyle = BorderStyle.FixedSingle;
            txtGhiChu.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGhiChu.ForeColor = Color.FromArgb(52, 73, 94);
            txtGhiChu.Location = new Point(140, 280);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(538, 229);
            txtGhiChu.TabIndex = 9;
            txtGhiChu.Text = "";
            // 
            // lblHang
            // 
            lblHang.AutoSize = true;
            lblHang.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            lblHang.ForeColor = Color.FromArgb(52, 73, 94);
            lblHang.Location = new Point(328, 38);
            lblHang.Name = "lblHang";
            lblHang.Size = new Size(189, 31);
            lblHang.TabIndex = 2;
            lblHang.Text = "Hạng giấy phép:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            lblGhiChu.ForeColor = Color.FromArgb(52, 73, 94);
            lblGhiChu.Location = new Point(32, 269);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(102, 31);
            lblGhiChu.TabIndex = 8;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // dtpNgayNop
            // 
            dtpNgayNop.BackColor = Color.White;
            dtpNgayNop.Enabled = false;
            dtpNgayNop.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayNop.ForeColor = Color.FromArgb(52, 73, 94);
            dtpNgayNop.Format = DateTimePickerFormat.Short;
            dtpNgayNop.Location = new Point(162, 202);
            dtpNgayNop.Name = "dtpNgayNop";
            dtpNgayNop.Size = new Size(230, 37);
            dtpNgayNop.TabIndex = 5;
            dtpNgayNop.Value = new DateTime(2025, 10, 15, 0, 0, 0, 0);
            // 
            // lblNgayNop
            // 
            lblNgayNop.AutoSize = true;
            lblNgayNop.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            lblNgayNop.ForeColor = Color.FromArgb(52, 73, 94);
            lblNgayNop.Location = new Point(32, 202);
            lblNgayNop.Name = "lblNgayNop";
            lblNgayNop.Size = new Size(124, 31);
            lblNgayNop.TabIndex = 4;
            lblNgayNop.Text = "Ngày nộp:";
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(255, 128, 128);
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(1630, 30);
            label13.TabIndex = 2;
            label13.Text = "Thêm mới hồ sơ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlButton
            // 
            pnlButton.BackColor = Color.FromArgb(245, 247, 250);
            pnlButton.Controls.Add(btnLuu);
            pnlButton.Controls.Add(btnHuy);
            pnlButton.Dock = DockStyle.Bottom;
            pnlButton.Location = new Point(0, 740);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(1630, 60);
            pnlButton.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(46, 204, 113);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(611, 10);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 40);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(231, 76, 60);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(826, 10);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(120, 40);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // UCThemHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(pnlMain);
            Name = "UCThemHoSo";
            Size = new Size(1630, 800);
            pnlMain.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhDaiDien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        public async Task LoadDataCCCD()              
        {
            try
            {
                if (comboBox1.SelectedItem == null) return;
                string maHang = comboBox1.SelectedItem.ToString()?.Trim();
                var congDanBLL = new CongDanBLL();
                var data = await congDanBLL.GetCongDanChuaCoHoSoAsync(maHang);
                // làm sạch trước khi bind lại để tránh lỗi sự kiện lặp
                cboCongDan.DataSource = null;
                cboCongDan.DisplayMember = null;
                cboCongDan.ValueMember = null;

                var cccdList = data.Select(cd => cd.Cccd).ToList();
                cboCongDan.DataSource = cccdList;                                                                                                               
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Phiên kết nối đã bị đóng. Hãy đăng nhập lại hoặc bỏ 'using' với DbContext dùng chung.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách CCCD: " + ex.Message);
            }
        }

        public void resetForm()
        {
            txtGhiChu.Clear();
            comboBox1.SelectedIndex = -1;
            cboCongDan.DataSource = null;
            cboCongDan.SelectedIndex = -1;
            dtpNgayNop.Value = DateTime.Now;
            pictureBoxAnhDaiDien.Image = null;
            txtTen.Clear();
            txtSDT.Clear();
            txtGioiTinh.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }


        #endregion
        private ComboBox cboCongDan;
        private DateTimePicker dtpNgayNop;
        private RichTextBox txtGhiChu;
        private Button btnLuu;
        private Button btnHuy;
        private Panel pnlMain;
        private Panel pnlButton;
        private Label lblCongDan;
        private Label lblHang;
        private Label lblNgayNop;
        private Label lblGhiChu;
        private Label label13;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox;
        private TextBox txtEmail;
        private Label label7;
        private Label label4;
        private DateTimePicker dtpNgaySinh;
        private Label label3;
        private PictureBox pictureBoxAnhDaiDien;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtDiaChi;
        private Label label16;
        private TextBox txtGioiTinh;
        private TextBox txtSDT;
        private Label label1;
        public int idCongDan;
    }
}
