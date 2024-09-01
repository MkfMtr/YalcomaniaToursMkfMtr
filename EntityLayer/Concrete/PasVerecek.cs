using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class PasVerecek
{
    public int Id { get; set; }

    public DateOnly Tarih { get; set; }

    public int Bilet { get; set; }

    public int Sirket { get; set; }

    public byte F { get; set; }

    public byte H { get; set; }

    public byte G { get; set; }

    public string? VerecekParaBirimi { get; set; }

    public decimal ToplamVerecek { get; set; }

    public decimal OdenenVerecek { get; set; }

    public bool SilindiMi { get; set; }

    public bool OdendiMi { get; set; }

    public virtual Bilet BiletNavigation { get; set; } = null!;

    public virtual Sirket SirketNavigation { get; set; } = null!;

    public virtual ParaBirimi? VerecekParaBirimiNavigation { get; set; }
}
