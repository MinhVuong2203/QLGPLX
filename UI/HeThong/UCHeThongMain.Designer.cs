namespace UI.HeThong
{
    partial class UCHeThongMain
    {
        private System.ComponentModel.IContainer components = null;
        public bool IsShowpass = false;
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
            dgv = new DataGridView();
            label13 = new Label();
            groupBoxThongTin = new GroupBox();
            txtPassword = new TextBox();
            ShowPass = new PictureBox();
            picAnh = new PictureBox();
            btnChonAnh = new Button();
            cboChucVu = new ComboBox();
            chkTrangThai = new CheckBox();
            txtDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtHoTen = new TextBox();
            txtMaCanBo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelButtons = new Panel();
            btnLamMoi = new Button();
            btnNgungViec = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(18, 278);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1391, 308);
            dgv.TabIndex = 0;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(255, 128, 128);
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Padding = new Padding(9, 0, 0, 0);
            label13.Size = new Size(1426, 30);
            label13.TabIndex = 3;
            label13.Text = "QUẢN LÝ CÁN BỘ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxThongTin
            // 
            groupBoxThongTin.Controls.Add(txtPassword);
            groupBoxThongTin.Controls.Add(ShowPass);
            groupBoxThongTin.Controls.Add(picAnh);
            groupBoxThongTin.Controls.Add(btnChonAnh);
            groupBoxThongTin.Controls.Add(cboChucVu);
            groupBoxThongTin.Controls.Add(chkTrangThai);
            groupBoxThongTin.Controls.Add(txtDienThoai);
            groupBoxThongTin.Controls.Add(txtEmail);
            groupBoxThongTin.Controls.Add(txtUsername);
            groupBoxThongTin.Controls.Add(txtHoTen);
            groupBoxThongTin.Controls.Add(txtMaCanBo);
            groupBoxThongTin.Controls.Add(label8);
            groupBoxThongTin.Controls.Add(label7);
            groupBoxThongTin.Controls.Add(label6);
            groupBoxThongTin.Controls.Add(label5);
            groupBoxThongTin.Controls.Add(label4);
            groupBoxThongTin.Controls.Add(label3);
            groupBoxThongTin.Controls.Add(label2);
            groupBoxThongTin.Controls.Add(label1);
            groupBoxThongTin.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxThongTin.Location = new Point(18, 45);
            groupBoxThongTin.Margin = new Padding(3, 2, 3, 2);
            groupBoxThongTin.Name = "groupBoxThongTin";
            groupBoxThongTin.Padding = new Padding(3, 2, 3, 2);
            groupBoxThongTin.Size = new Size(1050, 180);
            groupBoxThongTin.TabIndex = 4;
            groupBoxThongTin.TabStop = false;
            groupBoxThongTin.Text = "Thông tin cán bộ";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(131, 140);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 26);
            txtPassword.TabIndex = 18;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // ShowPass
            // 
            ShowPass.BackColor = Color.FromArgb(233, 233, 233);
            ShowPass.Image = Properties.Resources.CloseEyes;
            ShowPass.Location = new Point(355, 141);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(26, 20);
            ShowPass.SizeMode = PictureBoxSizeMode.Zoom;
            ShowPass.TabIndex = 4;
            ShowPass.TabStop = false;
            ShowPass.Click += ShowPass_Click;
            // 
            // picAnh
            // 
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(900, 21);
            picAnh.Margin = new Padding(3, 2, 3, 2);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(132, 150);
            picAnh.TabIndex = 17;
            picAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChonAnh.ForeColor = SystemColors.ActiveCaptionText;
            btnChonAnh.Location = new Point(788, 75);
            btnChonAnh.Margin = new Padding(3, 2, 3, 2);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(88, 29);
            btnChonAnh.TabIndex = 16;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.Font = new Font("Segoe UI", 10F);
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(525, 26);
            cboChucVu.Margin = new Padding(3, 2, 3, 2);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(219, 25);
            cboChucVu.TabIndex = 15;
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Font = new Font("Segoe UI", 10F);
            chkTrangThai.ForeColor = SystemColors.ActiveCaptionText;
            chkTrangThai.Location = new Point(525, 139);
            chkTrangThai.Margin = new Padding(3, 2, 3, 2);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(94, 23);
            chkTrangThai.TabIndex = 14;
            chkTrangThai.Text = "Hoạt động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 10F);
            txtDienThoai.Location = new Point(525, 101);
            txtDienThoai.Margin = new Padding(3, 2, 3, 2);
            txtDienThoai.MaxLength = 15;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(219, 25);
            txtDienThoai.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(525, 64);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 120;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 25);
            txtEmail.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(131, 101);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.MaxLength = 100;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 25);
            txtUsername.TabIndex = 10;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(131, 64);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.MaxLength = 100;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(219, 25);
            txtHoTen.TabIndex = 9;
            // 
            // txtMaCanBo
            // 
            txtMaCanBo.Enabled = false;
            txtMaCanBo.Font = new Font("Segoe UI", 10F);
            txtMaCanBo.Location = new Point(131, 26);
            txtMaCanBo.Margin = new Padding(3, 2, 3, 2);
            txtMaCanBo.Name = "txtMaCanBo";
            txtMaCanBo.ReadOnly = true;
            txtMaCanBo.Size = new Size(219, 25);
            txtMaCanBo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(411, 141);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 7;
            label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(411, 104);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 6;
            label7.Text = "Điện thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(411, 66);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(411, 28);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Chức vụ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(26, 141);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(26, 104);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(26, 66);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã cán bộ:";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnLamMoi);
            panelButtons.Controls.Add(btnNgungViec);
            panelButtons.Controls.Add(btnSua);
            panelButtons.Controls.Add(btnThem);
            panelButtons.Location = new Point(18, 232);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1050, 38);
            panelButtons.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(420, 4);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(122, 30);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnNgungViec
            // 
            btnNgungViec.BackColor = Color.FromArgb(220, 53, 69);
            btnNgungViec.FlatStyle = FlatStyle.Flat;
            btnNgungViec.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNgungViec.ForeColor = Color.White;
            btnNgungViec.Location = new Point(289, 4);
            btnNgungViec.Margin = new Padding(3, 2, 3, 2);
            btnNgungViec.Name = "btnNgungViec";
            btnNgungViec.Size = new Size(122, 30);
            btnNgungViec.TabIndex = 2;
            btnNgungViec.Text = "Ngưng việc";
            btnNgungViec.UseVisualStyleBackColor = false;
            btnNgungViec.Click += btnNgungViec_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 193, 7);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(158, 4);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(122, 30);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(26, 4);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(122, 30);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // UCHeThongMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panelButtons);
            Controls.Add(groupBoxThongTin);
            Controls.Add(label13);
            Controls.Add(dgv);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCHeThongMain";
            Size = new Size(1426, 600);
            Load += UCHeThongMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBoxThongTin.ResumeLayout(false);
            groupBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Label label13;
        private GroupBox groupBoxThongTin;
        private TextBox txtMaCanBo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkTrangThai;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtHoTen;
        private ComboBox cboChucVu;
        private Panel panelButtons;
        private Button btnThem;
        private Button btnSua;
        private Button btnNgungViec;
        private Button btnLamMoi;
        private Button btnChonAnh;
        private PictureBox picAnh;
        private PictureBox ShowPass;
       
    }
}