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
    }
}
