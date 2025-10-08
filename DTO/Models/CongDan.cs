using System;
using System.Collections.Generic;

namespace DAL;

public partial class CongDan
{
    public int MaCongDan { get; set; }

    public string HoTen { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string? GioiTinh { get; set; }

    public string Cccd { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public string? TinhTrangSucKhoe { get; set; }

    public DateOnly? NgayKhamSucKhoe { get; set; }

    public string? GiayKhamSucKhoe { get; set; }

    public DateTime NgayTao { get; set; }

    public string? Anh3x4 { get; set; }

    public virtual ICollection<GiayPhep> GiayPheps { get; set; } = new List<GiayPhep>();

    public virtual ICollection<HoSo> HoSos { get; set; } = new List<HoSo>();
}
