using System;
using System.Collections.Generic;

namespace DAL;

public partial class HoSo
{
    public int HoSoId { get; set; }

    public int MaCongDan { get; set; }

    public string MaHang { get; set; } = null!;

    public DateOnly NgayNop { get; set; }

    public string TrangThai { get; set; } = null!;

    public bool TrangThaiThanhToan { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<CanBoHoSo> CanBoHoSos { get; set; } = new List<CanBoHoSo>();

    public virtual ICollection<KetQuaThi> KetQuaThis { get; set; } = new List<KetQuaThi>();

    public virtual CongDan MaCongDanNavigation { get; set; } = null!;

    public virtual HangGiayPhep MaHangNavigation { get; set; } = null!;
}
