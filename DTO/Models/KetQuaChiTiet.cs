using System;
using System.Collections.Generic;

namespace DAL;

public partial class KetQuaChiTiet
{
    public int ChiTietId { get; set; }

    public int KetQuaId { get; set; }

    public string LoaiMon { get; set; } = null!;

    public decimal? Diem { get; set; }

    public DateTime? ThoiGianBatDau { get; set; }

    public string KetQua { get; set; } = null!;

    public string? GhiChu { get; set; }

    public virtual KetQuaThi KetQuaNavigation { get; set; } = null!;
}
