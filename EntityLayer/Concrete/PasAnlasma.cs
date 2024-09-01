using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class PasAnlasma
{
    public int Id { get; set; }

    public DateOnly Tarih { get; set; }

    public int Sirket { get; set; }

    public string AlacakParaBirimi { get; set; } = null!;

    public byte AlacakF { get; set; }

    public byte AlacakH { get; set; }

    public string VerecekParaBirimi { get; set; } = null!;

    public byte VerecekF { get; set; }

    public byte VerecehH { get; set; }

    public bool AnlasmaBittiMi { get; set; }

    public virtual ParaBirimi AlacakParaBirimiNavigation { get; set; } = null!;

    public virtual Sirket SirketNavigation { get; set; } = null!;

    public virtual ParaBirimi VerecekParaBirimiNavigation { get; set; } = null!;
}
