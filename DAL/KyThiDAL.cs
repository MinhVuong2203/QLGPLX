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

        public int GetDistinctParticipantCount(int kyThiId)
        {
            return DatabaseSession.Context.KetQuaThis
                .Where(k => k.KyThiId == kyThiId)
                .Select(k => k.HoSo.MaCongDan)
                .Distinct()
                .Count();
        }

        // Return HoSo that have the same MaHang as the kyThi and are not assigned to any KyThi yet
        // Only HoSo with TrangThai == "Đủ điều kiện" will be returned (business rule)
        public List<HoSo> GetPendingHoSoForKyThi(int kyThiId)
        {
            var ky = GetById(kyThiId);
            if (ky == null || string.IsNullOrEmpty(ky.MaHang))
                return new List<HoSo>();

            // HoSo already assigned to any KyThi
            var assignedHoSoIds = DatabaseSession.Context.KetQuaThis
                .Select(k => k.HoSoId)
                .Distinct();

            return DatabaseSession.Context.HoSos
                .Include(h => h.MaCongDanNavigation)
                .Where(h => h.MaHang == ky.MaHang
                            && !assignedHoSoIds.Contains(h.HoSoId)
                            && h.TrangThai == "Đủ điều kiện") // only eligible HoSo
                .ToList();
        }

        // Add a KetQuaThi entry for (kyThiId, hoSoId) with default values
        public void AddParticipant(int kyThiId, int hoSoId)
        {
            // if already exists for same kyThi and hoSo, skip
            var exists = DatabaseSession.Context.KetQuaThis.Any(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId);
            if (exists) return;

            var newEntry = new KetQuaThi
            {
                HoSoId = hoSoId,
                KyThiId = kyThiId,
                LanThi = 1,
                KetQuaTongHop = "Không đạt",
                NgayKetLuan = DateTime.Now
            };
            DatabaseSession.Context.KetQuaThis.Add(newEntry);
            DatabaseSession.Context.SaveChanges();
        }

        // Remove participant entries for a kyThi-hoSo pair (used when "Xóa" from a Sắp diễn ra kỳ thi)
        public void RemoveParticipant(int kyThiId, int hoSoId)
        {
            var items = DatabaseSession.Context.KetQuaThis
                .Where(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId)
                .ToList();
            if (!items.Any()) return;

            DatabaseSession.Context.KetQuaThis.RemoveRange(items);
            DatabaseSession.Context.SaveChanges();
        }

        // Add a retry attempt for a participant in an ongoing exam.
        // Returns true if new attempt added, false if already at max attempts (3).
        public bool RetryParticipant(int kyThiId, int hoSoId)
        {
            // find max existing LanThi for this pair
            var maxLan = DatabaseSession.Context.KetQuaThis
                .Where(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId)
                .Select(k => (int?)k.LanThi)
                .Max();

            int currentMax = maxLan ?? 0;
            if (currentMax >= 3)
            {
                return false; // cannot retry more than 3 times
            }

            var newEntry = new KetQuaThi
            {
                HoSoId = hoSoId,
                KyThiId = kyThiId,
                LanThi = currentMax + 1,
                KetQuaTongHop = "Không đạt",
                NgayKetLuan = DateTime.Now
            };

            DatabaseSession.Context.KetQuaThis.Add(newEntry);
            DatabaseSession.Context.SaveChanges();
            return true;
        }
        
    }

}