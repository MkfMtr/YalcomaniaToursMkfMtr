using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Calisan
{
    public int Id { get; set; }

    public string CalisanAdi { get; set; } = null!;

    public string? CalisanSoyadi { get; set; }

    public string CalisanTelNo { get; set; } = null!;

    public string CalisanMail { get; set; } = null!;

    public string CalisanSifre { get; set; } = null!;

    public bool SilindiMi { get; set; }

    public virtual ICollection<Bilet> Bilets { get; set; } = new List<Bilet>();
}
