using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Bilet
{
    public int Id { get; set; }

    public int TurId { get; set; }

    public int? YeniTurId { get; set; }

    public int SatanSubeId { get; set; }

    public int? SatanElemanId { get; set; }

    public string MusteriAd { get; set; } = null!;

    public string? MusteriSoyad { get; set; }

    public string MusteriUyruk { get; set; } = null!;

    public int MusteriBolgeId { get; set; }

    public int? MusteriOtelId { get; set; }

    public string? MusteriOdaNo { get; set; }

    public string? MusteriAdres { get; set; }

    public string MusteriTelNo { get; set; } = null!;

    public byte FullSayi { get; set; }

    public byte HalfSayi { get; set; }

    public byte GuestSayi { get; set; }

    public string ParaBirimi { get; set; } = null!;

    public decimal Paid { get; set; }

    public decimal Rest { get; set; }

    public bool OdendiMi { get; set; }

    public string? Aciklama { get; set; }

    public bool ServisIstiyorMu { get; set; }

    public TimeOnly? ServisSaati { get; set; }

    public bool BiletIptalMi { get; set; }

    public bool PasBiletMi { get; set; }

    public bool? GelenGidenPas { get; set; }

    public string? PasSirketi { get; set; }

    public virtual Bolge MusteriBolge { get; set; } = null!;

    public virtual Otel? MusteriOtel { get; set; }

    public virtual Uyruk MusteriUyrukNavigation { get; set; } = null!;

    public virtual ParaBirimi ParaBirimiNavigation { get; set; } = null!;

    public virtual ICollection<PasAlacak> PasAlacaks { get; set; } = new List<PasAlacak>();

    public virtual ICollection<PasVerecek> PasVereceks { get; set; } = new List<PasVerecek>();

    public virtual Calisan? SatanEleman { get; set; }

    public virtual Sube SatanSube { get; set; } = null!;

    public virtual Tur Tur { get; set; } = null!;

    public virtual Tur? YeniTur { get; set; }
}
