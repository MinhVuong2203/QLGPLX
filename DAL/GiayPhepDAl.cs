using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiayPhepDAl
    {
        // Lấy danh sách giấy phép theo trạng thái
        public List<GiayPhep> GetByTrangThaiAndMahang(string maHang, string trangThai)
        {
            return DatabaseSession.Context.GiayPheps
                .Include(g => g.MaCongDanNavigation)
                .Include(g => g.MaHangNavigation)
                .Where(g => g.TrangThai == trangThai && g.MaHang == maHang)
                .OrderByDescending(g => g.GiayPhepId)
                .ToList();
        }

        // Lấy giấy phép theo ID
        public GiayPhep GetById(int id)
        {
            return DatabaseSession.Context.GiayPheps
                .Include(g => g.MaCongDanNavigation)
                .Include(g => g.MaHangNavigation)
                .FirstOrDefault(g => g.GiayPhepId == id);
        }
      
  

        // Lấy giấy phép theo mã công và trạng thái dân Sắp xếp theo ngày cấp
        public GiayPhep GetByMaCongDan(int maCongDan, string TrangThai)
        {
            return DatabaseSession.Context.GiayPheps
                .Include(g => g.MaCongDanNavigation)
                .Include(g => g.MaHangNavigation)
                .OrderByDescending(g => g.NgayCap)
                .FirstOrDefault(g => g.MaCongDan == maCongDan && g.TrangThai == TrangThai);             
        }

        public GiayPhep GetBySoGiayPhep(string sogp, string trangthai)
        {
            return DatabaseSession.Context.GiayPheps
                .Include(g => g.MaCongDanNavigation)
                .Include(g => g.MaHangNavigation)
                .FirstOrDefault(g => g.SoGiayPhep == sogp && g.TrangThai == trangthai);
        }

        public bool UpdateDiem(GiayPhep gp, int soDiem)
        {
            try
            {
                
                if (gp == null)
                    throw new Exception("Không tìm thấy giấy phép cần cập nhật.");

                gp.SoDiem = soDiem;


                DatabaseSession.Context.GiayPheps.Update(gp);
                DatabaseSession.Context.SaveChanges(); // 🔥 Quan trọng: lưu xuống DB

                return true;
            }
            catch (Exception e)
            {
                // Gợi ý: in thông tin chi tiết để debug
                Console.WriteLine($"Lỗi UpdateDiem: {e.Message}");
                if (e.InnerException != null)
                    Console.WriteLine($"Chi tiết: {e.InnerException.Message}");

                return false;
            }
        }



    }
}
