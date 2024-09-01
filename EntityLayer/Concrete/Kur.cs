using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Kur
{
    public DateOnly Tarih { get; set; }

    public string ParaBirimiAdi { get; set; } = null!;

    public decimal DolaraOran { get; set; }

    public decimal EuroyaOran { get; set; }

    public virtual ParaBirimi ParaBirimiAdiNavigation { get; set; } = null!;
}
