using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoSoBLL
    {
        private readonly HoSoDAL hoSoDAL = new HoSoDAL();
        private readonly CanBoHoSoDAL canBoHoSoDAL = new CanBoHoSoDAL();

        public List<HoSo> GetAllHoSo(string trangthai)
        {
            return hoSoDAL.GetAllHoSo(trangthai);
        }

        public void DuyetHoSo(int hoSoId, int maCanBo)
        {
            hoSoDAL.UpdateTrangThai(hoSoId, "Đủ điều kiện");
            canBoHoSoDAL.AddCanBoHoSo(maCanBo, hoSoId, "Đủ điều kiện");
        }

        public void TuChoiHoSo(int hoSoId, int maCanBo)
        {
            hoSoDAL.UpdateTrangThai(hoSoId, "Không đủ điều kiện");
            canBoHoSoDAL.AddCanBoHoSo(maCanBo, hoSoId, "Không đủ điều kiện");
        }

        public bool ThemHoSo(HoSo hoSo)
        {
            try
            {
                DatabaseSession.Context.HoSos.Add(hoSo);
                DatabaseSession.Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
