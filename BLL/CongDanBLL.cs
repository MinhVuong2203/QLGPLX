using DAL;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class CongDanBLL
    {
        public CongDanDAL congDanDAL = new CongDanDAL();
        public CongDanBLL() { }

        public bool ThemCongDan(CongDan congDan)
        {
            if (congDan.HoTen == "")
                throw new Exception("Họ tên không được để trống");
            if (!Utils.ValidationHelper.IsValidCCCD(congDan.Cccd))
                throw new Exception("CCCD không hợp lệ!");
            if (!Utils.ValidationHelper.IsValidPhone(congDan.SoDienThoai))
                throw new Exception("Số điện thoại không hợp lệ.");
            if (!Utils.ValidationHelper.IsValidEmail(congDan.Email))
                throw new Exception("Email không hợp lệ.");
            return congDanDAL.ThemCongDan(congDan);
        }

        public bool CapNhatCongDan(CongDan congDan)
        {
            if (congDan.HoTen == "")
                throw new Exception("Họ tên không được để trống");
            if (!Utils.ValidationHelper.IsValidCCCD(congDan.Cccd))
                throw new Exception("CCCD không hợp lệ!");
            if (!Utils.ValidationHelper.IsValidPhone(congDan.SoDienThoai))
                throw new Exception("Số điện thoại không hợp lệ.");
            if (!Utils.ValidationHelper.IsValidEmail(congDan.Email))
                throw new Exception("Email không hợp lệ.");
            return congDanDAL.CapNhatCongDan(congDan);
        }

        public CongDan getCongDanByCCCD(string cccd)
        {
            return congDanDAL.GetCongDanByCCCD(cccd);
        }

        // Lấy ra danh sách công dân chưa có hồ sơ theo mã hạng
        public async Task<List<CongDan>> GetCongDanChuaCoHoSoAsync(string? maHang)
        {
            var db = DatabaseSession.Context;             
            var p = new SqlParameter("@MaHang", (object?)maHang ?? DBNull.Value);

            return await db.Set<CongDan>()
                           .FromSqlRaw("EXEC sp_CongDan_ChuaCoHoSo @MaHang", p)
                           .AsNoTracking()
                           .ToListAsync();
        }

    }
}
