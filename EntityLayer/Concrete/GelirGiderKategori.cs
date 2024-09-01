using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class GelirGiderKategori
{
    public int Id { get; set; }

    public string KategoriAdi { get; set; } = null!;

    public bool GelirGider { get; set; }

    public bool SilindiMi { get; set; }

    public virtual ICollection<Gelir> Gelirs { get; set; } = new List<Gelir>();

    public virtual ICollection<Gider> Giders { get; set; } = new List<Gider>();
}
