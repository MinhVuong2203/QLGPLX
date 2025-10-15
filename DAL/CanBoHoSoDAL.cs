using System;

namespace DAL
{
    public class CanBoHoSoDAL
    {
        public void AddCanBoHoSo(int maCanBo, int hoSoId, string trangThaiDuyet)
        {
            var cbhs = new CanBoHoSo
            {
                MaCanBo = maCanBo,
                HoSoId = hoSoId,
                ThoiGian = DateTime.Now,
                TrangThaiDuyet = trangThaiDuyet
            };
            DatabaseSession.Context.CanBoHoSos.Add(cbhs);
            DatabaseSession.Context.SaveChanges();
        }
    }
}