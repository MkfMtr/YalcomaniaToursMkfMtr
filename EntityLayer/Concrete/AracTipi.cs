using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class AracTipi
{
    public int Id { get; set; }

    public string AracTipiAdi { get; set; } = null!;

    public bool SilindiMi { get; set; }

    public virtual ICollection<AracVerecek> AracVereceks { get; set; } = new List<AracVerecek>();

    public virtual ICollection<Arac> Aracs { get; set; } = new List<Arac>();

    public virtual ICollection<TurTipi> TurTipis { get; set; } = new List<TurTipi>();
}
