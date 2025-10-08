using System;
using System.Collections.Generic;

namespace DAL;

public partial class ChucVu
{
    public int MaChucVu { get; set; }

    public string TenChucVu { get; set; } = null!;

    public virtual ICollection<CanBo> CanBos { get; set; } = new List<CanBo>();
}
