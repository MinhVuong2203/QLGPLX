using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TrangChu
{
    public partial class UCTrangChuMain : UserControl
    {
        private List<string> slideImages = new List<string>();
        private int currentIndex = 0;

        public UCTrangChuMain()
        {
            InitializeComponent();
            LoadSlideImages();
            ShowCurrentSlide();
        }

        private void LoadSlideImages()
        {
            // Đường dẫn thư mục chứa slide (có thể thay đổi theo cấu trúc project của bạn)
            string[] possiblePaths = new string[]
            {
                Path.Combine(Application.StartupPath, "slides"),
                Path.Combine(Application.StartupPath, "Resources", "slides"),
                Path.Combine(Directory.GetParent(Application.StartupPath).Parent.Parent.FullName, "slides"),
                Path.Combine(Directory.GetParent(Application.StartupPath).Parent.Parent.FullName, "Resources", "slides")
            };

            string slidePath = "";
            foreach (var path in possiblePaths)
            {
                if (Directory.Exists(path))
                {
                    slidePath = path;
                    break;
                }
            }

            // Nếu không tìm thấy thư mục, tạo thư mục mẫu
            if (string.IsNullOrEmpty(slidePath))
            {
                slidePath = Path.Combine(Application.StartupPath, "slides");
                Directory.CreateDirectory(slidePath);
            }

            // Tìm các file ảnh slide1, slide2, slide3, ...
            string[] extensions = new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };

            int slideNumber = 1;
            while (true)
            {
                bool found = false;
                foreach (var ext in extensions)
                {
                    string filePath = Path.Combine(slidePath, $"slide{slideNumber}{ext}");
                    if (File.Exists(filePath))
                    {
                        slideImages.Add(filePath);
                        found = true;
                        break;
                    }
                }

                if (!found)
                    break;

                slideNumber++;
            }

            // Nếu không có ảnh nào, hiển thị thông báo
            if (slideImages.Count == 0)
            {
                lblNoImages.Visible = true;
                lblNoImages.Text = $"Không tìm thấy ảnh slide.\nVui lòng đặt các file ảnh có tên:\nslide1.jpg, slide2.jpg, slide3.jpg, ...\nvào thư mục: {slidePath}";
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                lblNoImages.Visible = false;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                lblSlideInfo.Text = $"1 / {slideImages.Count}";
            }
        }

        private void ShowCurrentSlide()
        {
            if (slideImages.Count == 0)
                return;

            try
            {
                // Giải phóng ảnh cũ nếu có
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                }

                // Load ảnh mới
                pictureBox.Image = Image.FromFile(slideImages[currentIndex]);
                lblSlideInfo.Text = $"{currentIndex + 1} / {slideImages.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (slideImages.Count == 0)
                return;

            currentIndex--;
            if (currentIndex < 0)
                currentIndex = slideImages.Count - 1;

            ShowCurrentSlide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (slideImages.Count == 0)
                return;

            currentIndex++;
            if (currentIndex >= slideImages.Count)
                currentIndex = 0;

            ShowCurrentSlide();
        }
    }
}
