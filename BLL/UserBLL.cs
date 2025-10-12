using DAL;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Windows.Forms;

namespace BLL
{
    public class UserBLL
    {
        public UserBLL() {}
        public CanBo Login(string username, string password)
        {
            CanBo canBo = null;
            try
            {
                string connectionString = $"Data Source=DESKTOP-39G03JV\\SQLEXPRESS;" +
                                         $"Initial Catalog=QLGPLX;" +
                                         $"User ID={username};" +
                                         $"Password={password};" +
                                         $"TrustServerCertificate=True;" +
                                         $"Connection Timeout=5;";
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Close();
                }
                DatabaseSession.Initialize(username, password); // Khởi tạo kết nối với cơ sở dữ liệu, đối tượng này sẽ tồn tại xuyên suốt
                Debug.WriteLine("Khớp với database");
                canBo = DatabaseSession.Context.CanBos.Include(cb => cb.MaChucVuNavigation).FirstOrDefault(cb => cb.Username == username);
                Debug.WriteLine(canBo.MaCanBo);
                Debug.WriteLine(canBo.MaChucVuNavigation.TenChucVu);
                return canBo;
                // Chuyển sang form chính
                // this.Hide();
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi");
            }
            return canBo;
        }
    }
}
