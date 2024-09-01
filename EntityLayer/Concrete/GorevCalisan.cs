using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class GorevCalisan
{
    public int GorevId { get; set; }

    public int CalisanId { get; set; }

    public virtual Calisan Calisan { get; set; } = null!;

    public virtual Gorev Gorev { get; set; } = null!;
}
