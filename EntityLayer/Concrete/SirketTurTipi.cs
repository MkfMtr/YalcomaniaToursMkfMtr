using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class SirketTurTipi
{
    public int SirketId { get; set; }

    public int TurTipiId { get; set; }

    public virtual Sirket Sirket { get; set; } = null!;

    public virtual TurTipi TurTipi { get; set; } = null!;
}
