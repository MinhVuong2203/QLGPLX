namespace UI.KyThi
{
    partial class UCKyThiMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgv = new DataGridView();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label13 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            button1 = new Button();
            panelMain = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 230, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(34, 45, 65);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Location = new Point(55, 112);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 32;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1741, 797);
            dgv.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Locimg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(31, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 39);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đang diễn ra", "Sắp diễn ra", "Đã kết thúc" });
            comboBox1.Location = new Point(82, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 38);
            comboBox1.TabIndex = 10;
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(255, 192, 128);
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(1863, 29);
            label13.TabIndex = 9;
            label13.Text = "Duyệt hồ sơ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(624, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 45);
            btnThem.TabIndex = 13;
            btnThem.Text = "Tạo mới";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(889, 31);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(153, 45);
            btnSua.TabIndex = 14;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1173, 31);
            button1.Name = "button1";
            button1.Size = new Size(153, 45);
            button1.TabIndex = 15;
            button1.Text = "Thí sinh";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgv);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1863, 1067);
            panelMain.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 958);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1863, 109);
            panel1.TabIndex = 17;
            // 
            // UCKyThiMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label13);
            Controls.Add(panelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCKyThiMain";
            Size = new Size(1863, 1067);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public void LoadControl(UserControl uc)
        {
            this.panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(uc);
        }
        private DataGridView dgv;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label13;
        private Button btnThem;
        private Button btnSua;
        private Button button1;
        private Panel panelMain;
        private Panel panel1;
    }
}
