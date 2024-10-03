using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Tur
{
    public int Id { get; set; }

    public DateOnly Tarih { get; set; }

    public TimeOnly Saat { get; set; }

    public int TurTipiId { get; set; }

    public bool BittiMi { get; set; }

    public decimal FiyatTRY { get; set; }
    public decimal FiyatUSD { get; set; }
    public decimal FiyatEUR { get; set; }

    public int AracId1 { get; set; }

    public int? AracId2 { get; set; }

    public int? AracId3 { get; set; }

    public int? AracId4 { get; set; }

    public int? ServisId1 { get; set; }

    public int? ServisId2 { get; set; }

    public int? ServisId3 { get; set; }

    public bool TurIptalMi { get; set; }

    public virtual ICollection<AracVerecek> AracVereceks { get; set; } = new List<AracVerecek>();

    public virtual ICollection<Bilet> BiletTurs { get; set; } = new List<Bilet>();

    public virtual ICollection<Gelir> Gelirs { get; set; } = new List<Gelir>();

    public virtual ICollection<Gider> Giders { get; set; } = new List<Gider>();

    public virtual TurTipi TurTipi { get; set; } = null!;
}
