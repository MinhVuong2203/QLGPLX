namespace UI.KyThi
{
    partial class FormKyThiParticipants
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientSize = new Size(980, 660);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;
            this.Text = "Quản lý thí sinh - Kỳ thi";

            // top panel + header
            panelTop = new Panel { Dock = DockStyle.Top, Height = 56, BackColor = Color.FromArgb(255, 243, 230) };
            lblHeader = new Label
            {
                Text = "Danh sách thí sinh tham gia kỳ thi",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(34, 45, 65),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Padding = new Padding(12, 0, 0, 0)
            };
            panelTop.Controls.Add(lblHeader);
            this.Controls.Add(panelTop);

            // Participants grid (already in ky thi)
            dgvParticipants = new DataGridView
            {
                Location = new Point(12, 72),
                Size = new Size(952, 220),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvParticipants.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 230, 210);
            dgvParticipants.EnableHeadersVisualStyles = false;
            this.Controls.Add(dgvParticipants);

            // Pending label + grid
            label1 = new Label
            {
                Text = "Công dân chờ xếp vào kỳ thi (chỉ hiển thị khi kỳ thi chưa kết thúc)",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(34, 45, 65),
                Location = new Point(12, 310),
                AutoSize = true
            };
            this.Controls.Add(label1);

            dgvPending = new DataGridView
            {
                Location = new Point(12, 338),
                Size = new Size(952, 260),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                ReadOnly = false, // need button column
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvPending.EnableHeadersVisualStyles = false;
            dgvPending.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 230, 210);
            dgvPending.CellContentClick += DgvPending_CellContentClick;
            this.Controls.Add(dgvPending);

            // Close button
            btnClose = new Button
            {
                Text = "Đóng",
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(128, 203, 196),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 36),
                Location = new Point(864, 606),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }

        // Designer controls

        #endregion

        private Label label1;
        private DataGridView dgvPending;
        private Button  btnClose;
    }
}