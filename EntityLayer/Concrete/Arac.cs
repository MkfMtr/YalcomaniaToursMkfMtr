using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Arac
{
    public int Id { get; set; }

    public int AracTipiId { get; set; }

    public string PlakaVeyaIsim { get; set; } = null!;

    public bool SilindiMi { get; set; }

    public virtual AracTipi AracTipi { get; set; } = null!;
}
