using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CongDanDAL
    {
        public bool ThemCongDan(CongDan congdan)
        {
            try
            {
                DatabaseSession.Context.CongDans.Add(congdan);
                DatabaseSession.Context.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                // ❌ QUAN TRỌNG: Xóa entity khỏi DbContext để không lưu cache
                DatabaseSession.Context.Entry(congdan).State = EntityState.Detached;
                string errorMessage = GetFriendlyErrorMessage(ex);
                throw new Exception(errorMessage);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        private string GetFriendlyErrorMessage(DbUpdateException ex)
        {
            string innerMessage = ex.InnerException?.Message ?? "";

            // Kiểm tra lỗi UNIQUE constraint
            // SQL Server thường trả về: Violation of UNIQUE KEY constraint 'UQ_ColumnName'
            if (innerMessage.Contains("UNIQUE KEY constraint", StringComparison.OrdinalIgnoreCase))
            {
                if (innerMessage.Contains("UQ__CongDan__A955A0AA4D1EFAF8", StringComparison.OrdinalIgnoreCase) ||
                    innerMessage.Contains("CCCD", StringComparison.OrdinalIgnoreCase))
                    return "Số CCCD đã tồn tại trong hệ thống!";

                if (innerMessage.Contains("UQ__CongDan__A9D1053423DEB215", StringComparison.OrdinalIgnoreCase) ||
                    innerMessage.Contains("Email", StringComparison.OrdinalIgnoreCase))
                    return "Email đã tồn tại trong hệ thống!";

                if (innerMessage.Contains("UQ__CongDan__0389B7BDF110EE0A", StringComparison.OrdinalIgnoreCase) ||
                    innerMessage.Contains("SoDienThoai", StringComparison.OrdinalIgnoreCase) ||
                    innerMessage.Contains("SoDT", StringComparison.OrdinalIgnoreCase))
                    return "Số điện thoại đã tồn tại trong hệ thống!";
            }

            // Kiểm tra lỗi NOT NULL constraint
            if (innerMessage.Contains("NULL", StringComparison.OrdinalIgnoreCase))
            {
                if (innerMessage.Contains("GioiTinh", StringComparison.OrdinalIgnoreCase))
                    return "Vui lòng chọn giới tính!";

                return "Vui lòng điền đầy đủ thông tin bắt buộc!";
            }

            // Nếu không khớp với trường hợp nào, trả về message chi tiết
            return "Lỗi cơ sở dữ liệu: " + innerMessage;
        }

        public bool CapNhatCongDan(CongDan congdan)
        {
            try
            {
                var existingCongDan = DatabaseSession.Context.CongDans.FirstOrDefault(t => t.Cccd == congdan.Cccd);
                if (existingCongDan == null)
                    throw new Exception("Công dân không tồn tại trong hệ thống.");
                // Cập nhật các thuộc tính
                existingCongDan.HoTen = congdan.HoTen;
                existingCongDan.GioiTinh = congdan.GioiTinh;
                existingCongDan.NgaySinh = congdan.NgaySinh;
                existingCongDan.Cccd = congdan.Cccd;
                existingCongDan.DiaChi = congdan.DiaChi;
                existingCongDan.SoDienThoai = congdan.SoDienThoai;
                existingCongDan.Email = congdan.Email;
                existingCongDan.Anh3x4 = congdan.Anh3x4;
                existingCongDan.TinhTrangSucKhoe = congdan.TinhTrangSucKhoe;
                existingCongDan.NgayKhamSucKhoe = congdan.NgayKhamSucKhoe;
                existingCongDan.GiayKhamSucKhoe = congdan.GiayKhamSucKhoe;
                DatabaseSession.Context.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                string errorMessage = GetFriendlyErrorMessage(ex);
                throw new Exception(errorMessage);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public CongDan GetCongDanByCCCD(string cccd)
        {
            var congDan = DatabaseSession.Context.CongDans
                .FirstOrDefault(cd => cd.Cccd == cccd);
            return congDan;
        }


    }
}
