using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Bolge
{
    public int Id { get; set; }

    public string BolgeIsim { get; set; } = null!;

    public int BolgeMerkezeUzaklikMetre { get; set; }

    public TimeOnly ServisSaati { get; set; }

    public bool SilindiMi { get; set; }

    public virtual ICollection<Bilet> Bilets { get; set; } = new List<Bilet>();
}
