using BLL;
using DAL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI.KyThi
{
    public partial class FormKyThiEdit : Form
    {
        private readonly KyThiBLL _bll = new KyThiBLL();
        private DAL.KyThi _kyThi;
        private readonly bool _isNew;

        // Designer controls
        private Label lblHeader;
        private Label lblTen;
        private TextBox txtTenKyThi;
        private Label lblNgay;
        private DateTimePicker dtpNgayBatDau;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpNgayKetThuc;
        private Label label1;
        private ComboBox cboMaHang;
        private Label label4;
        private Label label3;
        private TextBox txtDiaDiem;
        private Label label2;
        private DateTimePicker dtpGioBatDau;
        private Button btnPlus;
        private Button btnMinus;
        private Label label5;
        private TextBox txtSoLuongToiDa;
        private Panel panel1;
        private Panel panelContent;

        public FormKyThiEdit()
        {
            InitializeComponent();
            _isNew = true;
            this.Text = "Tạo kỳ thi mới";
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        public FormKyThiEdit(int kyThiId) : this()
        {
            _kyThi = _bll.GetById(kyThiId);
            if (_kyThi != null)
            {
                txtTenKyThi.Text = _kyThi.TenKyThi;
                txtDiaDiem.Text = _kyThi.DiaDiem;
                txtSoLuongToiDa.Text = _kyThi.SoLuongToiDa.ToString();
                cboMaHang.SelectedItem = _kyThi.MaHang;
                dtpNgayBatDau.Value = _kyThi.NgayBatDau.ToDateTime(new TimeOnly(0, 0));
                dtpNgayKetThuc.Value = _kyThi.NgayKetThuc.Value.ToDateTime(TimeOnly.MinValue);
                dtpGioBatDau.Value = DateTime.Today.Add(_kyThi.GioBatDau.Value.ToTimeSpan());
                
                if (_kyThi.TrangThai == "Đang diễn ra" || _kyThi.TrangThai == "Đã kết thúc")
                {
                    txtTenKyThi.Enabled = false;
                    dtpNgayBatDau.Enabled = false;
                    btnSave.Enabled = false;
                    MessageBox.Show("Kỳ thi đang diễn ra hoặc đã kết thúc, không thể cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string ten = txtTenKyThi.Text.Trim();
            DateOnly ngayBatDau = DateOnly.FromDateTime(dtpNgayBatDau.Value);
            DateOnly ngayKetThuc = DateOnly.FromDateTime(dtpNgayKetThuc.Value);
            TimeOnly gioBatDau = TimeOnly.FromDateTime(dtpGioBatDau.Value);
            string maHang = cboMaHang.SelectedItem?.ToString();
            string diaDiem = txtDiaDiem.Text.Trim();
            int soLuongToiDa = int.Parse(txtSoLuongToiDa.Text);

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên kỳ thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ngayBatDau <= DateOnly.FromDateTime(DateTime.Now))
            {
                MessageBox.Show("Ngày diễn ra phải là ngày trong tương lai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Bắt đầu phải trước hoặc bằng kết thúc");
                return;
            }

            if (_isNew)
            {
                var ky = new DAL.KyThi
                {
                    TenKyThi = ten,
                    NgayBatDau = ngayBatDau,
                    NgayKetThuc = ngayKetThuc,
                    GioBatDau = gioBatDau,
                    MaHang = maHang,
                    DiaDiem = diaDiem,
                    SoLuongToiDa = soLuongToiDa,
                    TrangThai = "Sắp diễn ra"
                };
                _bll.Create(ky);
                MessageBox.Show("Tạo kỳ thi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _kyThi.TenKyThi = ten;
                _kyThi.NgayBatDau = ngayBatDau;
                _kyThi.NgayKetThuc = ngayKetThuc;
                _kyThi.GioBatDau = gioBatDau;
                _kyThi.MaHang = maHang;
                _kyThi.DiaDiem = diaDiem;
                _kyThi.SoLuongToiDa = soLuongToiDa;
                _bll.Update(_kyThi);
                MessageBox.Show("Cập nhật kỳ thi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitializeComponent()
        {
            lblHeader = new Label();
            panelContent = new Panel();
            btnPlus = new Button();
            btnMinus = new Button();
            label5 = new Label();
            txtSoLuongToiDa = new TextBox();
            cboMaHang = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtDiaDiem = new TextBox();
            label2 = new Label();
            dtpGioBatDau = new DateTimePicker();
            dtpNgayKetThuc = new DateTimePicker();
            label1 = new Label();
            lblTen = new Label();
            txtTenKyThi = new TextBox();
            lblNgay = new Label();
            dtpNgayBatDau = new DateTimePicker();
            panel1 = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            panelContent.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(255, 240, 220);
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(34, 45, 65);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(12, 0, 0, 0);
            lblHeader.Size = new Size(388, 48);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Tạo / Cập nhật kỳ thi";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(btnPlus);
            panelContent.Controls.Add(btnMinus);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(txtSoLuongToiDa);
            panelContent.Controls.Add(cboMaHang);
            panelContent.Controls.Add(label4);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(txtDiaDiem);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(dtpGioBatDau);
            panelContent.Controls.Add(dtpNgayKetThuc);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(lblTen);
            panelContent.Controls.Add(txtTenKyThi);
            panelContent.Controls.Add(lblNgay);
            panelContent.Controls.Add(dtpNgayBatDau);
            panelContent.Controls.Add(panel1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 48);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(388, 434);
            panelContent.TabIndex = 0;
            // 
            // btnPlus
            // 
            btnPlus.BackgroundImage = Properties.Resources.plus;
            btnPlus.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlus.Location = new Point(240, 315);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(28, 28);
            btnPlus.TabIndex = 19;
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackgroundImage = Properties.Resources.minus;
            btnMinus.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinus.Location = new Point(109, 315);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(28, 28);
            btnMinus.TabIndex = 18;
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 289);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 14;
            label5.Text = "Số lượng tối đa:";
            // 
            // txtSoLuongToiDa
            // 
            txtSoLuongToiDa.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuongToiDa.Location = new Point(143, 315);
            txtSoLuongToiDa.Name = "txtSoLuongToiDa";
            txtSoLuongToiDa.Size = new Size(91, 30);
            txtSoLuongToiDa.TabIndex = 15;
            txtSoLuongToiDa.TextAlign = HorizontalAlignment.Right;
            txtSoLuongToiDa.KeyPress += txtSoLuongToiDa_KeyPress;
            // 
            // cboMaHang
            // 
            cboMaHang.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Items.AddRange(new object[] { "A1", "A" });
            cboMaHang.Location = new Point(206, 184);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(141, 31);
            cboMaHang.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(208, 156);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 12;
            label4.Text = "Mã hạng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 225);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 10;
            label3.Text = "Địa điểm:";
            // 
            // txtDiaDiem
            // 
            txtDiaDiem.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaDiem.Location = new Point(33, 251);
            txtDiaDiem.Name = "txtDiaDiem";
            txtDiaDiem.Size = new Size(326, 30);
            txtDiaDiem.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 85);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 8;
            label2.Text = "Giờ bắt đầu:";
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.CalendarFont = new Font("Segoe UI", 12.75F);
            dtpGioBatDau.CustomFormat = "HH:mm";
            dtpGioBatDau.Font = new Font("Segoe UI", 12.75F);
            dtpGioBatDau.Format = DateTimePickerFormat.Custom;
            dtpGioBatDau.Location = new Point(208, 114);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new Size(151, 30);
            dtpGioBatDau.TabIndex = 9;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CalendarFont = new Font("Segoe UI", 12.75F);
            dtpNgayKetThuc.CustomFormat = "dd-MM-yyyy";
            dtpNgayKetThuc.Font = new Font("Segoe UI", 12.75F);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(34, 185);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.ShowUpDown = true;
            dtpNgayKetThuc.Size = new Size(150, 30);
            dtpNgayKetThuc.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 156);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 6;
            label1.Text = "Ngày kết thúc:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen.Location = new Point(33, 20);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(88, 23);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên kỳ thi:";
            // 
            // txtTenKyThi
            // 
            txtTenKyThi.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKyThi.Location = new Point(33, 46);
            txtTenKyThi.Name = "txtTenKyThi";
            txtTenKyThi.Size = new Size(326, 30);
            txtTenKyThi.TabIndex = 1;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgay.Location = new Point(33, 85);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(119, 23);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "Ngày bắt đầu:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CalendarFont = new Font("Segoe UI", 12.75F);
            dtpNgayBatDau.CustomFormat = "dd-MM-yyyy";
            dtpNgayBatDau.Font = new Font("Segoe UI", 12.75F);
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(33, 114);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.ShowUpDown = true;
            dtpNgayBatDau.Size = new Size(151, 30);
            dtpNgayBatDau.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(20, 359);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 55);
            panel1.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(72, 201, 176);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12.75F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(202, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 36);
            btnSave.TabIndex = 5;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(239, 83, 80);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12.75F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(53, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormKyThiEdit
            // 
            AcceptButton = btnSave;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(388, 482);
            Controls.Add(panelContent);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormKyThiEdit";
            StartPosition = FormStartPosition.CenterParent;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (this.txtSoLuongToiDa.Text == "") this.txtSoLuongToiDa.Text = 1 + "";
            this.txtSoLuongToiDa.Text = (int.Parse(this.txtSoLuongToiDa.Text) + 1).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.txtSoLuongToiDa.Text) <= 0) return;
            this.txtSoLuongToiDa.Text = (int.Parse(this.txtSoLuongToiDa.Text) - 1).ToString();
        }

        private void txtSoLuongToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}