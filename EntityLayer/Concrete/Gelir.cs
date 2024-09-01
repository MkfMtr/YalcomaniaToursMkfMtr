using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Gelir
{
    public int Id { get; set; }

    public int TurId { get; set; }

    public int KategoriId { get; set; }

    public decimal Miktar { get; set; }

    public string? Aciklama { get; set; }

    public virtual GelirGiderKategori Kategori { get; set; } = null!;

    public virtual Tur Tur { get; set; } = null!;
}
