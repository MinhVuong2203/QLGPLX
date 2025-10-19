using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangGiayPhepDAL
    {
        public HangGiayPhep GetHangGiayPhep(string maHang)
        {
            return DatabaseSession.Context.HangGiayPheps.FirstOrDefault(t => t.MaHang == maHang);   
        }
    }
}
