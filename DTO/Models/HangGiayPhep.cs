using System;
using System.Collections.Generic;

namespace DAL;

public partial class HangGiayPhep
{
    public string MaHang { get; set; } = null!;

    public string TenHang { get; set; } = null!;

    public string? MoTa { get; set; }

    public int DoTuoiToiThieu { get; set; }

    public int? SoCauThiLyThuyet { get; set; }

    public int? ThoiGianThiLyThuyet { get; set; }

    public decimal? DiemDatLyThuyet { get; set; }

    public decimal? DiemDatThucHanh { get; set; }

    public virtual ICollection<GiayPhep> GiayPheps { get; set; } = new List<GiayPhep>();

    public virtual ICollection<HoSo> HoSos { get; set; } = new List<HoSo>();

    public virtual ICollection<KyThi> KyThis { get; set; } = new List<KyThi>();
}
