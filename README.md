Update: Scaffold-DbContext "Data Source=DESKTOP-39G03JV\SQLEXPRESS;Initial Catalog=QLGPLX;User ID=sa;Password=***;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -ContextDir ../DAL -OutputDir ../DTO/Models -Context QLGPLXContext -f
Color: rgb(237, 175, 81) rgb(226, 221, 154)

size UserControl(1300, 800)

// giữ cả code và sửa trên đây
git pull origin main --rebase
git push origin main

// Xem ràng buộc Unique
  SELECT name 
  FROM sys.key_constraints 
  WHERE type = 'UQ' AND parent_object_id = OBJECT_ID('CongDan')

  // hiển thị ảnh nếu có
  if (!string.IsNullOrEmpty(congDan.Anh3x4))
  {
      string solutionPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
      string imagePath = Path.Combine(solutionPath, "Resources", congDan.Anh3x4);

      if (File.Exists(imagePath))
      {
          using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
          pictureBoxAnhDaiDien.Image = Image.FromStream(stream);
      }
  }
