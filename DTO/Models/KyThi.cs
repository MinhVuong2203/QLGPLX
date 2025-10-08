using System;
using System.Collections.Generic;

namespace DAL;

public partial class KyThi
{
    public int KyThiId { get; set; }

    public string TenKyThi { get; set; } = null!;

    public DateOnly NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public TimeOnly? GioBatDau { get; set; }

    public string? DiaDiem { get; set; }

    public string MaHang { get; set; } = null!;

    public int? SoLuongToiDa { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<KetQuaThi> KetQuaThis { get; set; } = new List<KetQuaThi>();

    public virtual HangGiayPhep MaHangNavigation { get; set; } = null!;
}
