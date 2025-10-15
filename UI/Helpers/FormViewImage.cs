using DAL;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace UI.Helpers
{
    public class FormViewImage : Form
    {
        private PictureBox pictureBox;

        public FormViewImage(string imageFileName)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Black;
            StartPosition = FormStartPosition.CenterScreen;

            pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Black
            };
            if (!string.IsNullOrEmpty(imageFileName))
            {
                string solutionPath = System.IO.Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string imagePath = System.IO.Path.Combine(solutionPath, "Resources", imageFileName);          
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }
            Controls.Add(pictureBox);

            KeyDown += (s, e) => { if (e.KeyCode == Keys.Escape) Close(); };
            Click += (s, e) => Close();
            pictureBox.Click += (s, e) => Close();
        }
    }
}