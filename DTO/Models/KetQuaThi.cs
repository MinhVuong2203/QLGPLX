using System;
using System.Collections.Generic;

namespace DAL;

public partial class KetQuaThi
{
    public int KetQuaId { get; set; }

    public int HoSoId { get; set; }

    public int KyThiId { get; set; }

    public string KetQuaTongHop { get; set; } = null!;

    public DateTime NgayKetLuan { get; set; }

    public int LanThi { get; set; }

    public string? GhiChu { get; set; }

    public virtual HoSo HoSo { get; set; } = null!;

    public virtual ICollection<KetQuaChiTiet> KetQuaChiTiets { get; set; } = new List<KetQuaChiTiet>();

    public virtual KyThi KyThi { get; set; } = null!;
}
