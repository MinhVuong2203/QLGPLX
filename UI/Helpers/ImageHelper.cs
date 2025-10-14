using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Helpers
{
    public static class ImageHelper
    {
        public static string LuuAnh(PictureBox pictureBox, string tenFile)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;
                    try
                    {
                        // Xác định thư mục đích
                        string solutionPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                        string destFolder = Path.Combine(solutionPath, "Resources");

                        // Tạo thư mục nếu chưa có
                        if (!Directory.Exists(destFolder))
                        {
                            Directory.CreateDirectory(destFolder);
                        }

                        // Tạo đường dẫn file đích
                        string extension = Path.GetExtension(sourcePath);
                        string fileName = tenFile + extension;
                        string destPath = Path.Combine(destFolder, fileName);

                        // Giải phóng ảnh cũ
                        if (pictureBox.Image != null)
                        {
                            var oldImage = pictureBox.Image;
                            pictureBox.Image = null;
                            oldImage.Dispose();
                        }

                        // Xóa file cũ nếu trùng tên
                        if (File.Exists(destPath))
                        {
                            File.Delete(destPath);
                        }

                        // Copy file vào project
                        File.Copy(sourcePath, destPath, true);

                        // Hiển thị ảnh mới
                        using (var stream = new FileStream(destPath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox.Image = Image.FromStream(stream);
                        }

                        MessageBox.Show("Ảnh đã được lưu thành công!",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể lưu ảnh: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            return null;
        }
        
    }
}
