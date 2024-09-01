using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Gorev
{
    public int Id { get; set; }

    public string GorevAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public bool SilindiMi { get; set; }
}
