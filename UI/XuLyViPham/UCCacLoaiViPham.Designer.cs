using DAL;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI.XuLyViPham
{
    partial class UCCacLoaiViPham
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
            dgv = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
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
            label13.Text = "Các loại vi phạm phổ biến";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(57, 141);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1500, 600);
            dgv.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(57, 57);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 12;
            label1.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(187, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(602, 37);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // UCCacLoaiViPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgv);
            Controls.Add(label13);
            Name = "UCCacLoaiViPham";
            Size = new Size(1630, 800);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        public void Load()
        {

            _listViPham = _viphamDAL.GetAllViPham();
            this.dgv.DataSource = _listViPham.Select(k => new
            {
                k.LoaiViPhamId,
                k.TenViPham,
                k.DiemTru,
                k.MucPhatTu,
                k.MucPhatDen,
                k.MoTa
            }).ToList();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.ForeColor = Color.Black;       // màu chữ mặc định
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            if (dgv.Columns["LoaiViPhamId"] != null) dgv.Columns["LoaiViPhamId"].HeaderText = "Loại vi phạm";
            if (dgv.Columns["TenViPham"] != null) dgv.Columns["TenViPham"].HeaderText = "Tên vi phạm";
            if (dgv.Columns["DiemTru"] != null) dgv.Columns["DiemTru"].HeaderText = "Điểm trừ";
            if (dgv.Columns["MucPhatTu"] != null) dgv.Columns["MucPhatTu"].HeaderText = "Mức phạt từ";
            if (dgv.Columns["MucPhatDen"] != null) dgv.Columns["MucPhatDen"].HeaderText = "Mức phạt đến";
            if (dgv.Columns["MoTa"] != null) dgv.Columns["MoTa"].HeaderText = "Mô tả";
        }
        #endregion

        private Label label13;
        private DataGridView dgv;
        private Label label1;
        private TextBox txtSearch;
        private ViPhamDAL _viphamDAL = new ViPhamDAL();
        private List<LoaiViPham> _listViPham;

    }
}
