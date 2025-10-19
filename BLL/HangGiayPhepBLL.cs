using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HangGiayPhepBLL
    {
        public HangGiayPhepDAL _hangGiayPhepDAL = new HangGiayPhepDAL();
        public HangGiayPhep GetHangGiayPhep(string maHang)
        {
            return _hangGiayPhepDAL.GetHangGiayPhep(maHang);
        }
    }
}
