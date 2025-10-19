using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ViPhamDAL
    {
        public List<LoaiViPham> GetAllViPham()
        {
            return DatabaseSession.Context.LoaiViPhams.ToList();
        }

        public LoaiViPham GetById(int id) {
            return DatabaseSession.Context.LoaiViPhams.FirstOrDefault(t => t.LoaiViPhamId == id);
        }
    }
}
