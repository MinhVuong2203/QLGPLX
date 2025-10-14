using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class Tinh
    {
        public int matinhBNV { get; set; }
        public int matinhTMS { get; set; }
        public string tentinhmoi { get; set; }
        public List<PhuongXa> phuongxa { get; set; }
    }

    public class PhuongXa
    {
        public int maphuongxa { get; set; }
        public string tenphuongxa { get; set; }
    }
}
