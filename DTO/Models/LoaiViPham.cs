using System;
using System.Collections.Generic;

namespace DAL;

public partial class LoaiViPham
{
    public int LoaiViPhamId { get; set; }

    public string TenViPham { get; set; } = null!;

    public int DiemTru { get; set; }

    public decimal? MucPhatTu { get; set; }

    public decimal? MucPhatDen { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<ViPham> ViPhams { get; set; } = new List<ViPham>();
}
