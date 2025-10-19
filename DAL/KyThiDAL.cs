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
                KetQuaTongHop = "Chưa thi",
                NgayKetLuan = DateTime.Now
            };
            DatabaseSession.Context.KetQuaThis.Add(newEntry);
            DatabaseSession.Context.SaveChanges();
            DatabaseSession.Context.ChangeTracker.Clear();
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
                KetQuaTongHop = "Chưa thi",
                NgayKetLuan = DateTime.Now
            };

            DatabaseSession.Context.KetQuaThis.Add(newEntry);
            DatabaseSession.Context.SaveChanges();
            DatabaseSession.Context.ChangeTracker.Clear();
            return true;
        }

        public string getMaHangByKyThi(int kythiId)
        {
            return DatabaseSession.Context.KyThis
                .Where(k => k.KyThiId == kythiId)
                .Select(k => k.MaHang)
                .FirstOrDefault();
        }


        /* ---------- New methods for result input and helpers ---------- */

        // lấy danh sách kỳ thi "Đang diễn ra"
        public List<KyThi> GetOngoingKyThi()
        {
            return DatabaseSession.Context.KyThis
                .Where(k => k.TrangThai == "Đang diễn ra")
                .OrderByDescending(k => k.KyThiId)
                .ToList();
        }

        // Lấy ra Kết quả thi mới nhất của thí sinh trong kỳ thi
        public KetQuaThi GetLatestKetQuaThi(int kyThiId, int hoSoId)
        {
            return DatabaseSession.Context.KetQuaThis
                .Include(k => k.HoSo)
                    .ThenInclude(h => h.MaCongDanNavigation)
                .Include(k => k.KetQuaChiTiets)
                .Where(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId)
                .OrderByDescending(k => k.LanThi)
                .FirstOrDefault();
        }

        // lấy tất cả thí sinh tham gia kỳ thi, chỉ lấy bản ghi KetQuaThi có LanThi cao nhất cho mỗi HoSo
        public List<KetQuaThi> GetDistinctParticipantsForKyThi(int kyThiId)
        {
            // get latest LanThi record per HoSo for this KyThi (if multiple lan, show latest)
            var q = DatabaseSession.Context.KetQuaThis
                .Include(k => k.HoSo)
                    .ThenInclude(h => h.MaCongDanNavigation)
                .Where(k => k.KyThiId == kyThiId)
                .GroupBy(k => k.HoSoId)
                .Select(g => g.OrderByDescending(x => x.LanThi).FirstOrDefault());

            return q.ToList();
        }

        // Save or update result for a given KyThi/HoSo/LanThi.
        // diemLy and diemThuc are nullable - only provided fields will be saved.
        // This method also updates KetQuaChiTiet rows (LoaiMon = "Lý thuyết" / "Thực hành") and KetQuaTongHop.
        public void SaveOrUpdateResult(int kyThiId, int hoSoId, int lanThi, decimal? diemLy, decimal? diemThuc)
        {
            // Kiểm tra KetQuaThi đã tồn tại chưa
            var ketQuaId = DatabaseSession.Context.KetQuaThis
                .Where(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId && k.LanThi == lanThi)
                .Select(k => k.KetQuaId)
                .FirstOrDefault();

            if (ketQuaId == 0)
            {
                // Tạo mới KetQuaThi
                DatabaseSession.Context.Database.ExecuteSqlRaw(
                    @"INSERT INTO KetQuaThi (HoSoID, KyThiID, LanThi, NgayKetLuan, KetQuaTongHop) 
              VALUES ({0}, {1}, {2}, GETDATE(), N'Không đạt')",
                    hoSoId, kyThiId, lanThi);

                ketQuaId = DatabaseSession.Context.KetQuaThis
                    .Where(k => k.KyThiId == kyThiId && k.HoSoId == hoSoId && k.LanThi == lanThi)
                    .Select(k => k.KetQuaId)
                    .First();
            }

            // Lưu điểm Lý thuyết bằng raw SQL - THÊM KetQua = '' để tránh NULL
            if (diemLy.HasValue)
            {
                DatabaseSession.Context.Database.ExecuteSqlRaw(
                    @"IF EXISTS (SELECT 1 FROM KetQuaChiTiet WHERE KetQuaID = {0} AND LoaiMon = N'Lý thuyết')
                UPDATE KetQuaChiTiet SET Diem = {1}, ThoiGianBatDau = GETDATE() 
                WHERE KetQuaID = {0} AND LoaiMon = N'Lý thuyết'
              ELSE
                INSERT INTO KetQuaChiTiet (KetQuaID, LoaiMon, Diem, KetQua, ThoiGianBatDau) 
                VALUES ({0}, N'Lý thuyết', {1}, N'Không đạt', GETDATE())",
                    ketQuaId, diemLy.Value);
            }

            // Lưu điểm Thực hành bằng raw SQL - THÊM KetQua = '' để tránh NULL
            if (diemThuc.HasValue)
            {
                DatabaseSession.Context.Database.ExecuteSqlRaw(
                    @"IF EXISTS (SELECT 1 FROM KetQuaChiTiet WHERE KetQuaID = {0} AND LoaiMon = N'Thực hành')
                UPDATE KetQuaChiTiet SET Diem = {1}, ThoiGianBatDau = GETDATE() 
                WHERE KetQuaID = {0} AND LoaiMon = N'Thực hành'
              ELSE
                INSERT INTO KetQuaChiTiet (KetQuaID, LoaiMon, Diem, KetQua, ThoiGianBatDau) 
                VALUES ({0}, N'Thực hành', {1}, N'Không đạt', GETDATE())",
                    ketQuaId, diemThuc.Value);
            }

            // Trigger sẽ tự động cập nhật KetQua từ '' thành 'Đạt' hoặc 'Không đạt'
            DatabaseSession.Context.ChangeTracker.Clear();
        }

    }

}