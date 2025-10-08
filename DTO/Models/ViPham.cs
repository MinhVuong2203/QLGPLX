using System;
using System.Collections.Generic;

namespace DAL;

public partial class ViPham
{
    public int ViPhamId { get; set; }

    public int GiayPhepId { get; set; }

    public int LoaiViPhamId { get; set; }

    public DateTime ThoiGianViPham { get; set; }

    public string? DiaDiem { get; set; }

    public string? BienKiemSoat { get; set; }

    public decimal? MucPhat { get; set; }

    public string TrangThai { get; set; } = null!;

    public string? GhiChu { get; set; }

    public virtual GiayPhep GiayPhep { get; set; } = null!;

    public virtual LoaiViPham LoaiViPham { get; set; } = null!;
}
