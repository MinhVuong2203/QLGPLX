namespace UI.KyThi
{
    partial class UCKetQuaThi
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
            cboKyThi = new ComboBox();
            lbKiThi = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1 = new GroupBox();
            button1 = new Button();
            cboLanThi = new ComboBox();
            label8 = new Label();
            panel2 = new Panel();
            dtpThoiGianThucHanh = new DateTimePicker();
            lbKetQuaThucHanh = new Label();
            label3 = new Label();
            label9 = new Label();
            txtDiemThucHanh = new TextBox();
            label5 = new Label();
            lbKetQuaTongHop = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            cboThiSinh = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            dtpThoiGianLyThuyet = new DateTimePicker();
            label4 = new Label();
            lbKetQuaLyThuyet = new Label();
            txtDiemLyThuyet = new TextBox();
            label7 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboKyThi
            // 
            cboKyThi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboKyThi.FormattingEnabled = true;
            cboKyThi.Location = new Point(466, 48);
            cboKyThi.Name = "cboKyThi";
            cboKyThi.Size = new Size(877, 38);
            cboKyThi.TabIndex = 0;
            cboKyThi.SelectedIndexChanged += cboKyThi_SelectedIndexChanged;
            // 
            // lbKiThi
            // 
            lbKiThi.AutoSize = true;
            lbKiThi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbKiThi.ForeColor = SystemColors.ActiveCaptionText;
            lbKiThi.Location = new Point(323, 51);
            lbKiThi.Name = "lbKiThi";
            lbKiThi.Size = new Size(137, 31);
            lbKiThi.TabIndex = 1;
            lbKiThi.Text = "Chọn kỳ thi:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cboLanThi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(lbKetQuaTongHop);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cboThiSinh);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(229, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1186, 677);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả chi tiết";
            // 
            // button1
            // 
            button1.Location = new Point(997, 607);
            button1.Name = "button1";
            button1.Size = new Size(152, 45);
            button1.TabIndex = 23;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // cboLanThi
            // 
            cboLanThi.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboLanThi.FormattingEnabled = true;
            cboLanThi.Location = new Point(207, 104);
            cboLanThi.Name = "cboLanThi";
            cboLanThi.Size = new Size(249, 38);
            cboLanThi.TabIndex = 22;
            cboLanThi.SelectedIndexChanged += CboLanThi_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(46, 107);
            label8.Name = "label8";
            label8.Size = new Size(144, 31);
            label8.TabIndex = 21;
            label8.Text = "Chọn lần thi:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(dtpThoiGianThucHanh);
            panel2.Controls.Add(lbKetQuaThucHanh);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtDiemThucHanh);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(77, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(638, 198);
            panel2.TabIndex = 20;
            // 
            // dtpThoiGianThucHanh
            // 
            dtpThoiGianThucHanh.CalendarFont = new Font("Segoe UI", 12.75F);
            dtpThoiGianThucHanh.CustomFormat = "HH:mm dd-MM-yyyy";
            dtpThoiGianThucHanh.Font = new Font("Segoe UI", 12.75F);
            dtpThoiGianThucHanh.Format = DateTimePickerFormat.Custom;
            dtpThoiGianThucHanh.Location = new Point(265, 86);
            dtpThoiGianThucHanh.Name = "dtpThoiGianThucHanh";
            dtpThoiGianThucHanh.ShowUpDown = true;
            dtpThoiGianThucHanh.Size = new Size(341, 36);
            dtpThoiGianThucHanh.TabIndex = 12;
            // 
            // lbKetQuaThucHanh
            // 
            lbKetQuaThucHanh.AutoSize = true;
            lbKetQuaThucHanh.ForeColor = SystemColors.ActiveCaptionText;
            lbKetQuaThucHanh.Location = new Point(146, 140);
            lbKetQuaThucHanh.Name = "lbKetQuaThucHanh";
            lbKetQuaThucHanh.Size = new Size(64, 31);
            lbKetQuaThucHanh.TabIndex = 17;
            lbKetQuaThucHanh.Text = "_____";
            lbKetQuaThucHanh.TextChanged += lbKetQuaLyThuyet_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 28);
            label3.Name = "label3";
            label3.Size = new Size(217, 31);
            label3.TabIndex = 6;
            label3.Text = "Điểm thi thực hành:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(47, 141);
            label9.Name = "label9";
            label9.Size = new Size(99, 31);
            label9.TabIndex = 16;
            label9.Text = "Kết quả:";
            // 
            // txtDiemThucHanh
            // 
            txtDiemThucHanh.Location = new Point(232, 25);
            txtDiemThucHanh.Name = "txtDiemThucHanh";
            txtDiemThucHanh.Size = new Size(374, 37);
            txtDiemThucHanh.TabIndex = 8;
            txtDiemThucHanh.Leave += txtDiemThucHanh_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(13, 86);
            label5.Name = "label5";
            label5.Size = new Size(246, 31);
            label5.TabIndex = 11;
            label5.Text = "Thời gian thi lý thuyết:";
            // 
            // lbKetQuaTongHop
            // 
            lbKetQuaTongHop.AutoSize = true;
            lbKetQuaTongHop.ForeColor = SystemColors.ActiveCaptionText;
            lbKetQuaTongHop.Location = new Point(253, 615);
            lbKetQuaTongHop.Name = "lbKetQuaTongHop";
            lbKetQuaTongHop.Size = new Size(68, 31);
            lbKetQuaTongHop.TabIndex = 18;
            lbKetQuaTongHop.Text = ".........";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(46, 615);
            label6.Name = "label6";
            label6.Size = new Size(201, 31);
            label6.TabIndex = 13;
            label6.Text = "Kết quả tổng hợp:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(794, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 400);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // cboThiSinh
            // 
            cboThiSinh.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboThiSinh.FormattingEnabled = true;
            cboThiSinh.Location = new Point(207, 47);
            cboThiSinh.Name = "cboThiSinh";
            cboThiSinh.Size = new Size(508, 38);
            cboThiSinh.TabIndex = 3;
            cboThiSinh.SelectedIndexChanged += CboThiSinh_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(46, 50);
            label1.Name = "label1";
            label1.Size = new Size(155, 31);
            label1.TabIndex = 0;
            label1.Text = "Chọn thí sinh:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpThoiGianLyThuyet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbKetQuaLyThuyet);
            panel1.Controls.Add(txtDiemLyThuyet);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(77, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 198);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(21, 30);
            label2.Name = "label2";
            label2.Size = new Size(204, 31);
            label2.TabIndex = 4;
            label2.Text = "Điểm thi lý thuyết:";
            // 
            // dtpThoiGianLyThuyet
            // 
            dtpThoiGianLyThuyet.CalendarFont = new Font("Segoe UI", 12.75F);
            dtpThoiGianLyThuyet.CustomFormat = "HH:mm dd-MM-yyyy";
            dtpThoiGianLyThuyet.Font = new Font("Segoe UI", 12.75F);
            dtpThoiGianLyThuyet.Format = DateTimePickerFormat.Custom;
            dtpThoiGianLyThuyet.Location = new Point(273, 85);
            dtpThoiGianLyThuyet.Name = "dtpThoiGianLyThuyet";
            dtpThoiGianLyThuyet.ShowUpDown = true;
            dtpThoiGianLyThuyet.Size = new Size(341, 36);
            dtpThoiGianLyThuyet.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(21, 85);
            label4.Name = "label4";
            label4.Size = new Size(246, 31);
            label4.TabIndex = 9;
            label4.Text = "Thời gian thi lý thuyết:";
            // 
            // lbKetQuaLyThuyet
            // 
            lbKetQuaLyThuyet.AutoSize = true;
            lbKetQuaLyThuyet.ForeColor = SystemColors.ActiveCaptionText;
            lbKetQuaLyThuyet.Location = new Point(154, 135);
            lbKetQuaLyThuyet.Name = "lbKetQuaLyThuyet";
            lbKetQuaLyThuyet.Size = new Size(64, 31);
            lbKetQuaLyThuyet.TabIndex = 15;
            lbKetQuaLyThuyet.Text = "_____";
            lbKetQuaLyThuyet.TextChanged += lbKetQuaLyThuyet_TextChanged;
            // 
            // txtDiemLyThuyet
            // 
            txtDiemLyThuyet.Location = new Point(240, 27);
            txtDiemLyThuyet.Name = "txtDiemLyThuyet";
            txtDiemLyThuyet.Size = new Size(374, 37);
            txtDiemLyThuyet.TabIndex = 7;
            txtDiemLyThuyet.Leave += txtDiemLyThuyet_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(55, 136);
            label7.Name = "label7";
            label7.Size = new Size(99, 31);
            label7.TabIndex = 14;
            label7.Text = "Kết quả:";
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
            label13.TabIndex = 11;
            label13.Text = "Quản lý kết quả";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UCKetQuaThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label13);
            Controls.Add(groupBox1);
            Controls.Add(lbKiThi);
            Controls.Add(cboKyThi);
            Name = "UCKetQuaThi";
            Size = new Size(1630, 800);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboKyThi;
        private Label lbKiThi;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox1;
        private ComboBox cboThiSinh;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private TextBox txtDiemThucHanh;
        private TextBox txtDiemLyThuyet;
        private Label label3;
        private Label lbKetQuaLyThuyet;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpThoiGianThucHanh;
        private Label label5;
        private DateTimePicker dtpThoiGianLyThuyet;
        private Panel panel2;
        private Label lbKetQuaThucHanh;
        private Label label9;
        private Label lbKetQuaTongHop;
        private Panel panel1;
        private ComboBox cboLanThi;
        private Label label8;
        private Label label13;
        private Button button1;
    }
}
