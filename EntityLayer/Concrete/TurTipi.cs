using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class TurTipi
{
    public int Id { get; set; }

    public string TurTipiAdi { get; set; } = null!;

    public int AracTipiId { get; set; }

    public bool SilindiMi { get; set; }

    public virtual AracTipi AracTipi { get; set; } = null!;

    public virtual ICollection<Tur> Turs { get; set; } = new List<Tur>();
}
