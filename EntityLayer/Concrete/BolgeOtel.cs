using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class BolgeOtel
{
    public int BolgeId { get; set; }

    public int OtelId { get; set; }

    public virtual Bolge Bolge { get; set; } = null!;

    public virtual Otel Otel { get; set; } = null!;
}
