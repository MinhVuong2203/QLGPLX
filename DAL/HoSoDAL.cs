using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoSoDAL
    {
        public List<HoSo> GetAllHoSo(string trangThai)
        {
            return DatabaseSession.Context.HoSos
                .Where(h => h.TrangThai == trangThai)
                .Include(h => h.MaCongDanNavigation)
                .ToList();
        }

        public void UpdateTrangThai(int hoSoId, string trangThai)
        {
            var hoSo = DatabaseSession.Context.HoSos.Find(hoSoId);
            if (hoSo != null)
            {
                hoSo.TrangThai = trangThai;
                DatabaseSession.Context.SaveChanges();
            }
        }
    }
}
