using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Utils
{
    public class ValidationHelper
    {
        public static bool IsValidCCCD(string cccd)
        {
            return Regex.IsMatch(cccd ?? "", @"^\d{12}$");
        }

        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone ?? "", @"^0\d{9}$");
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return true;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidNgaySinh(DateTime ngaySinh)
        {
            return ngaySinh.Year >= 1900 && ngaySinh <= DateTime.Now;
        }
        public static bool IsValidBienSo(string bienSo)
        {
            if (string.IsNullOrWhiteSpace(bienSo))
                return false;
            bienSo = bienSo.Trim().ToUpper();
            // Linh hoạt: chấp nhận cả có hoặc không dấu chấm
            string pattern = @"^[0-9]{2}[A-Z]{1,2}-[0-9]{3,5}(\.[0-9]{2})?$";

            return Regex.IsMatch(bienSo, pattern);
        }
    }
}
