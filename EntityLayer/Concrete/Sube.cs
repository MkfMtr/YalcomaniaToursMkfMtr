using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Sube
{
    public int Id { get; set; }

    public string SubeAd { get; set; } = null!;

    public bool SilindiMi { get; set; }

    public virtual ICollection<Bilet> Bilets { get; set; } = new List<Bilet>();
}
