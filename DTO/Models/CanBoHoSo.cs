using System;
using System.Collections.Generic;

namespace DAL;

public partial class CanBoHoSo
{
    public int MaCanBo { get; set; }

    public int HoSoId { get; set; }

    public DateTime ThoiGian { get; set; }

    public string? TrangThaiDuyet { get; set; }

    public virtual HoSo HoSo { get; set; } = null!;

    public virtual CanBo MaCanBoNavigation { get; set; } = null!;
}
