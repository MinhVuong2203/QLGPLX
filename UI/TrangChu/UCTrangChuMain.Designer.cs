namespace UI.TrangChu
{
    partial class UCTrangChuMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSlideInfo;
        private System.Windows.Forms.Label lblNoImages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            btnPrev = new Button();
            btnNext = new Button();
            lblSlideInfo = new Label();
            lblNoImages = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1630, 716);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom;
            btnPrev.BackColor = Color.FromArgb(52, 152, 219);
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(600, 735);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(112, 50);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "◄";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom;
            btnNext.BackColor = Color.FromArgb(52, 152, 219);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(910, 735);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(120, 50);
            btnNext.TabIndex = 2;
            btnNext.Text = "►";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblSlideInfo
            // 
            lblSlideInfo.Anchor = AnchorStyles.Bottom;
            lblSlideInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSlideInfo.Location = new Point(730, 735);
            lblSlideInfo.Name = "lblSlideInfo";
            lblSlideInfo.Size = new Size(170, 50);
            lblSlideInfo.TabIndex = 3;
            lblSlideInfo.Text = "0 / 0";
            lblSlideInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNoImages
            // 
            lblNoImages.Anchor = AnchorStyles.None;
            lblNoImages.Font = new Font("Segoe UI", 16F);
            lblNoImages.ForeColor = Color.Gray;
            lblNoImages.Location = new Point(300, 250);
            lblNoImages.Name = "lblNoImages";
            lblNoImages.Size = new Size(1030, 300);
            lblNoImages.TabIndex = 4;
            lblNoImages.Text = "Không tìm thấy ảnh slide";
            lblNoImages.TextAlign = ContentAlignment.MiddleCenter;
            lblNoImages.Visible = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 716);
            panel1.Name = "panel1";
            panel1.Size = new Size(1630, 84);
            panel1.TabIndex = 5;
            // 
            // UCTrangChuMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblNoImages);
            Controls.Add(lblSlideInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(pictureBox);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCTrangChuMain";
            Size = new Size(1630, 800);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }
        private Panel panel1;
    }
}