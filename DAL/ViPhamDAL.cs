using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ViPhamDAL
    {

        public void XuLyViPham(ViPham viPham, int diemMoi)
        {
            using (var transaction = DatabaseSession.Context.Database.BeginTransaction())
            {
                try
                {
                    // ===== 1️⃣ Ghi nhận vi phạm mới =====
                   

                    // ===== 3️⃣ Commit giao dịch =====
                    transaction.Commit();
                  
                }
                catch (Exception e)
                {
                    // Nếu có lỗi => rollback
                    transaction.Rollback();

                    Console.WriteLine($"Lỗi XuLyViPham: {e.Message}");
                    if (e.InnerException != null)
                        Console.WriteLine($"Chi tiết: {e.InnerException.Message}");
                   
                }
            }
        }


        public List<LoaiViPham> GetAllViPham()
        {
            return DatabaseSession.Context.LoaiViPhams.ToList();
        }

        public LoaiViPham GetById(int id) {
            return DatabaseSession.Context.LoaiViPhams.FirstOrDefault(t => t.LoaiViPhamId == id);
        }
    }
}
