namespace UI.XuLyViPham
{
    partial class UCXuLyViPhamMain
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
        public void LoadControl(UserControl uc)
        {
            this.panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(uc);
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            parrotFlatMenuStrip1 = new ReaLTaiizor.Controls.ParrotFlatMenuStrip();
            thôngTinCôngDânToolStripMenuItem = new ToolStripMenuItem();
            hồSơCôngDânToolStripMenuItem = new ToolStripMenuItem();
            cácLoạiToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            parrotFlatMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // parrotFlatMenuStrip1
            // 
            parrotFlatMenuStrip1.AutoSize = false;
            parrotFlatMenuStrip1.BackColor = Color.Khaki;
            parrotFlatMenuStrip1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotFlatMenuStrip1.HoverBackColor = Color.Gold;
            parrotFlatMenuStrip1.HoverTextColor = Color.Black;
            parrotFlatMenuStrip1.ImageScalingSize = new Size(20, 20);
            parrotFlatMenuStrip1.ItemBackColor = Color.Beige;
            parrotFlatMenuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinCôngDânToolStripMenuItem, hồSơCôngDânToolStripMenuItem, cácLoạiToolStripMenuItem });
            parrotFlatMenuStrip1.Location = new Point(0, 0);
            parrotFlatMenuStrip1.Name = "parrotFlatMenuStrip1";
            parrotFlatMenuStrip1.SelectedBackColor = Color.FromArgb(255, 128, 0);
            parrotFlatMenuStrip1.SelectedTextColor = Color.White;
            parrotFlatMenuStrip1.SeparatorColor = Color.White;
            parrotFlatMenuStrip1.Size = new Size(1830, 48);
            parrotFlatMenuStrip1.TabIndex = 2;
            parrotFlatMenuStrip1.Text = "parrotFlatMenuStrip1";
            parrotFlatMenuStrip1.TextColor = Color.Black;
            // 
            // thôngTinCôngDânToolStripMenuItem
            // 
            thôngTinCôngDânToolStripMenuItem.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thôngTinCôngDânToolStripMenuItem.ForeColor = Color.White;
            thôngTinCôngDânToolStripMenuItem.Name = "thôngTinCôngDânToolStripMenuItem";
            thôngTinCôngDânToolStripMenuItem.Size = new Size(120, 44);
            thôngTinCôngDânToolStripMenuItem.Text = "Ghi nhận";
            thôngTinCôngDânToolStripMenuItem.Click += thôngTinCôngDânToolStripMenuItem_Click;
            // 
            // hồSơCôngDânToolStripMenuItem
            // 
            hồSơCôngDânToolStripMenuItem.AutoSize = false;
            hồSơCôngDânToolStripMenuItem.ForeColor = Color.Black;
            hồSơCôngDânToolStripMenuItem.Name = "hồSơCôngDânToolStripMenuItem";
            hồSơCôngDânToolStripMenuItem.Size = new Size(152, 44);
            hồSơCôngDânToolStripMenuItem.Text = "Tra cứu";
            // 
            // cácLoạiToolStripMenuItem
            // 
            cácLoạiToolStripMenuItem.ForeColor = Color.Black;
            cácLoạiToolStripMenuItem.Name = "cácLoạiToolStripMenuItem";
            cácLoạiToolStripMenuItem.Size = new Size(109, 44);
            cácLoạiToolStripMenuItem.Text = "Các loại";
            cácLoạiToolStripMenuItem.Click += cácLoạiToolStripMenuItem_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 48);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1830, 752);
            panelMain.TabIndex = 3;
            // 
            // UCXuLyViPhamMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(parrotFlatMenuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCXuLyViPhamMain";
            Size = new Size(1830, 800);
            parrotFlatMenuStrip1.ResumeLayout(false);
            parrotFlatMenuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotFlatMenuStrip parrotFlatMenuStrip1;
        private ToolStripMenuItem thôngTinCôngDânToolStripMenuItem;
        private ToolStripMenuItem hồSơCôngDânToolStripMenuItem;
        private ToolStripMenuItem cácLoạiToolStripMenuItem;
        private Panel panelMain;
    }
}
