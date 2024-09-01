using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Otel
{
    public int Id { get; set; }

    public string OtelIsim { get; set; } = null!;

    public int OtelMerkezeUzaklikMetre { get; set; }

    public bool SilindiMi { get; set; }

    public virtual ICollection<Bilet> Bilets { get; set; } = new List<Bilet>();
}
