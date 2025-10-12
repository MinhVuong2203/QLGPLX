using DAL;
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
    }
}
