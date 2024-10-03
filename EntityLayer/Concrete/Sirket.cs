using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Sirket
{
    public int Id { get; set; }

    public string SirketAdi { get; set; } = null!;

    public string SirketMail { get; set; } = null!;

    public string? SirketTelNo { get; set; }

    public string SirketGirisAdi { get; set; } = null!;

    public string SirketSifre { get; set; } = null!;

    public bool SilindiMi { get; set; }

    public virtual ICollection<Arac> Aracs { get; set; } = new List<Arac>();

    public virtual ICollection<AracVerecek> AracVereceks { get; set; } = new List<AracVerecek>();

    public virtual ICollection<PasAlacak> PasAlacaks { get; set; } = new List<PasAlacak>();

    public virtual ICollection<PasAnlasma> PasAnlasmas { get; set; } = new List<PasAnlasma>();

    public virtual ICollection<PasVerecek> PasVereceks { get; set; } = new List<PasVerecek>();
}
