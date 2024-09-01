using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class BolgeSube
{
    public int BolgeId { get; set; }

    public int SubeId { get; set; }

    public virtual Bolge Bolge { get; set; } = null!;

    public virtual Sube Sube { get; set; } = null!;
}
