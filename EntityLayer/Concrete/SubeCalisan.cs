using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class SubeCalisan
{
    public int SubeId { get; set; }

    public int CalisanId { get; set; }

    public virtual Calisan Calisan { get; set; } = null!;

    public virtual Sube Sube { get; set; } = null!;
}
