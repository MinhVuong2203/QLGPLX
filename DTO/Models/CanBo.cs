using System;
using System.Collections.Generic;

namespace DAL;

public partial class CanBo
{
    public int MaCanBo { get; set; }

    public string HoTen { get; set; } = null!;

    public int MaChucVu { get; set; }

    public string? Email { get; set; }

    public string? DienThoai { get; set; }

    public DateTime? NgayTao { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<CanBoHoSo> CanBoHoSos { get; set; } = new List<CanBoHoSo>();

    public virtual ChucVu MaChucVuNavigation { get; set; } = null!;
}
