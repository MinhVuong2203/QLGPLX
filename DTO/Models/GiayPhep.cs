using System;
using System.Collections.Generic;

namespace DAL;

public partial class GiayPhep
{
    public int GiayPhepId { get; set; }

    public int MaCongDan { get; set; }

    public string MaHang { get; set; } = null!;

    public string SoGiayPhep { get; set; } = null!;

    public DateOnly NgayCap { get; set; }

    public DateOnly? NgayHetHan { get; set; }

    public string TrangThai { get; set; } = null!;

    public string? GhiChu { get; set; }

    public int? SoDiem { get; set; }

    public virtual CongDan MaCongDanNavigation { get; set; } = null!;

    public virtual HangGiayPhep MaHangNavigation { get; set; } = null!;

    public virtual ICollection<ViPham> ViPhams { get; set; } = new List<ViPham>();
}
