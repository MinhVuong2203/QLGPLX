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

