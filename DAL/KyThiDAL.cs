using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class KyThiDAL
    {
        public List<KyThi> GetAll(string trangThaiFilter = null)
        {
            var q = DatabaseSession.Context.KyThis.AsQueryable();
            if (!string.IsNullOrEmpty(trangThaiFilter))
            {
                q = q.Where(k => k.TrangThai == trangThaiFilter);
            }
            return q.OrderByDescending(k => k.KyThiId).ToList();
        }

        public KyThi GetById(int id)
        {
            return DatabaseSession.Context.KyThis
                .FirstOrDefault(k => k.KyThiId == id);
        }

        public void Add(KyThi kyThi)
        {
            DatabaseSession.Context.KyThis.Add(kyThi);
            DatabaseSession.Context.SaveChanges();
        }

        public void Update(KyThi kyThi)
        {
            DatabaseSession.Context.KyThis.Update(kyThi);
            DatabaseSession.Context.SaveChanges();
        }

        public List<KetQuaThi> GetParticipants(int kyThiId)
        {
            return DatabaseSession.Context.KetQuaThis
                .Include(k => k.HoSo)
                    .ThenInclude(h => h.MaCongDanNavigation)
                .Where(k => k.KyThiId == kyThiId)
                .ToList();
        }
    }
}