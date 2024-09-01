using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class AracVerecek
{
    public int Id { get; set; }

    public int Sirket { get; set; }

    public int Tur { get; set; }

    public int AracTipi { get; set; }

    public byte AracSayisi { get; set; }

    public string VerecekParaBirimi { get; set; } = null!;

    public decimal ToplamVerecek { get; set; }

    public decimal OdenenVerecek { get; set; }

    public bool SilindiMi { get; set; }

    public bool OdendiMi { get; set; }

    public virtual AracTipi AracTipiNavigation { get; set; } = null!;

    public virtual Sirket SirketNavigation { get; set; } = null!;

    public virtual Tur TurNavigation { get; set; } = null!;

    public virtual ParaBirimi VerecekParaBirimiNavigation { get; set; } = null!;
}
