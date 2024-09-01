using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class ParaBirimi
{
    public string Iso4217 { get; set; } = null!;

    public string ParaBirimiAdi { get; set; } = null!;

    public bool SilindiMi { get; set; }

    public virtual ICollection<AracVerecek> AracVereceks { get; set; } = new List<AracVerecek>();

    public virtual ICollection<Bilet> Bilets { get; set; } = new List<Bilet>();

    public virtual ICollection<Kur> Kurs { get; set; } = new List<Kur>();

    public virtual ICollection<PasAlacak> PasAlacaks { get; set; } = new List<PasAlacak>();

    public virtual ICollection<PasAnlasma> PasAnlasmaAlacakParaBirimiNavigations { get; set; } = new List<PasAnlasma>();

    public virtual ICollection<PasAnlasma> PasAnlasmaVerecekParaBirimiNavigations { get; set; } = new List<PasAnlasma>();

    public virtual ICollection<PasVerecek> PasVereceks { get; set; } = new List<PasVerecek>();
}
