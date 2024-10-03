using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Arac
{
    public int Id { get; set; }

    public int SahipSirket { get; set; }

    public int AracTipiId { get; set; }

    public byte Kapasite { get; set; }

    public string PlakaVeyaIsim { get; set; } = null!;

    public bool SilindiMi { get; set; }

    public virtual Sirket SirketNavigation { get; set; } = null!;

    public virtual AracTipi AracTipi { get; set; } = null!;

    public virtual ICollection<Bilet> BiletAracs { get; set; } = new List<Bilet>();

    public virtual ICollection<Bilet> BiletServises { get; set; } = new List<Bilet>();
}
