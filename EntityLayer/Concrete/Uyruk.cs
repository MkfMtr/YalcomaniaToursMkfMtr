using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Uyruk
{
    public string Alpha3Code { get; set; } = null!;

    public string UlkeIsmi { get; set; } = null!;

    public bool SilindiMi { get; set; }

    public virtual ICollection<Bilet> Bilets { get; set; } = new List<Bilet>();
}
