namespace UI.XuLyViPham
{
    partial class UCPhucHoi
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
            dgv = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(67, 134);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1480, 537);
            dgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(533, 58);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 1;
            label1.Text = "Số GPLX:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(644, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(526, 37);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            label13.Text = "Phục hồi GPLX cho các báo thủ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UCPhucHoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label13);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "UCPhucHoi";
            Size = new Size(1630, 800);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private TextBox txtSearch;
        private Label label13;
    }
}
