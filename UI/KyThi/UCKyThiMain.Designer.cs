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
            parrotFlatMenuStrip1 = new ReaLTaiizor.Controls.ParrotFlatMenuStrip();
            thôngTinCôngDânToolStripMenuItem = new ToolStripMenuItem();
            hồSơCôngDânToolStripMenuItem = new ToolStripMenuItem();
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
            parrotFlatMenuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinCôngDânToolStripMenuItem, hồSơCôngDânToolStripMenuItem });
            parrotFlatMenuStrip1.Location = new Point(0, 0);
            parrotFlatMenuStrip1.Name = "parrotFlatMenuStrip1";
            parrotFlatMenuStrip1.SelectedBackColor = Color.FromArgb(255, 128, 0);
            parrotFlatMenuStrip1.SelectedTextColor = Color.White;
            parrotFlatMenuStrip1.SeparatorColor = Color.White;
            parrotFlatMenuStrip1.Size = new Size(952, 48);
            parrotFlatMenuStrip1.TabIndex = 1;
            parrotFlatMenuStrip1.Text = "parrotFlatMenuStrip1";
            parrotFlatMenuStrip1.TextColor = Color.Black;
            // 
            // thôngTinCôngDânToolStripMenuItem
            // 
            thôngTinCôngDânToolStripMenuItem.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thôngTinCôngDânToolStripMenuItem.ForeColor = Color.Black;
            thôngTinCôngDânToolStripMenuItem.Name = "thôngTinCôngDânToolStripMenuItem";
            thôngTinCôngDânToolStripMenuItem.Size = new Size(86, 44);
            thôngTinCôngDânToolStripMenuItem.Text = "Kỳ thi";
            thôngTinCôngDânToolStripMenuItem.Click += thôngTinCôngDânToolStripMenuItem_Click;
            // 
            // hồSơCôngDânToolStripMenuItem
            // 
            hồSơCôngDânToolStripMenuItem.AutoSize = false;
            hồSơCôngDânToolStripMenuItem.ForeColor = Color.White;
            hồSơCôngDânToolStripMenuItem.Name = "hồSơCôngDânToolStripMenuItem";
            hồSơCôngDânToolStripMenuItem.Size = new Size(152, 44);
            hồSơCôngDânToolStripMenuItem.Text = "Kết quả";
            hồSơCôngDânToolStripMenuItem.Click += hồSơCôngDânToolStripMenuItem_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 48);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(952, 628);
            panelMain.TabIndex = 2;
            // 
            // UCKyThiMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(parrotFlatMenuStrip1);
            Name = "UCKyThiMain";
            Size = new Size(952, 676);
            parrotFlatMenuStrip1.ResumeLayout(false);
            parrotFlatMenuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public void LoadControl(UserControl uc)
        {
            this.panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(uc);
        }
        private ReaLTaiizor.Controls.ParrotFlatMenuStrip parrotFlatMenuStrip1;
        private ToolStripMenuItem thôngTinCôngDânToolStripMenuItem;
        private ToolStripMenuItem hồSơCôngDânToolStripMenuItem;
        private Panel panelMain;
    }
}
