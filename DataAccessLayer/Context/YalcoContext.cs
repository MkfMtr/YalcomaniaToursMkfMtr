using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context;

public partial class YalcoContext : DbContext
{
    public YalcoContext()
    {
    }

    public YalcoContext(DbContextOptions<YalcoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Arac> Araclar { get; set; }

    public virtual DbSet<AracTipi> AracTipleri { get; set; }

    public virtual DbSet<AracVerecek> AracVerecekler { get; set; }

    public virtual DbSet<Bilet> Biletler { get; set; }

    public virtual DbSet<Bolge> Bolgeler { get; set; }

    public virtual DbSet<BolgeOtel> BolgelerOteller { get; set; }

    public virtual DbSet<BolgeSube> BolgelerSubeler { get; set; }

    public virtual DbSet<Calisan> Calisanlar { get; set; }

    public virtual DbSet<Gelir> Gelirler { get; set; }

    public virtual DbSet<GelirGiderKategori> GelirGiderKategoriler { get; set; }

    public virtual DbSet<Gider> Giderler { get; set; }

    public virtual DbSet<Gorev> Gorevler { get; set; }

    public virtual DbSet<GorevCalisan> GorevlerCalisanlar { get; set; }

    public virtual DbSet<Kur> Kurlar { get; set; }

    public virtual DbSet<Otel> Oteller { get; set; }

    public virtual DbSet<ParaBirimi> ParaBirimleri { get; set; }

    public virtual DbSet<PasAlacak> PasAlacaklar { get; set; }

    public virtual DbSet<PasAnlasma> PasAnlasmalar { get; set; }

    public virtual DbSet<PasVerecek> PasVerecekler { get; set; }

    public virtual DbSet<SirketTurTipi> SirketTurTipleri { get; set; }

    public virtual DbSet<Sirket> Sirketler { get; set; }

    public virtual DbSet<Sube> Subeler { get; set; }

    public virtual DbSet<SubeCalisan> SubelerCalisanlar { get; set; }

    public virtual DbSet<Tur> Turlar { get; set; }

    public virtual DbSet<TurTipi> TurTipleri { get; set; }

    public virtual DbSet<Uyruk> Uyruklar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=DESKTOP-I3A8MJ6\\SQLEXPRESS;database=YalcomaniaDB;Integrated Security=true;TrustServerCertificate=True;");
    //Burada "DB_CONNECTION_STRING" environment variable kullanabilirim.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Arac>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Araclar");

            entity.ToTable("Arac");

            entity.Property(e => e.PlakaVeyaIsim).HasMaxLength(50);

            entity.HasOne(d => d.AracTipi).WithMany(p => p.Aracs)
                .HasForeignKey(d => d.AracTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Araclar_AracTipleri");
        });

        modelBuilder.Entity<AracTipi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AracTipleri");

            entity.ToTable("AracTipi");

            entity.Property(e => e.AracTipiAdi).HasMaxLength(50);
        });

        modelBuilder.Entity<AracVerecek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AracAnlasmalar");

            entity.ToTable("AracVerecek");

            entity.Property(e => e.OdenenVerecek).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ToplamVerecek).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VerecekParaBirimi)
                .HasMaxLength(3)
                .IsFixedLength();

            entity.HasOne(d => d.AracTipiNavigation).WithMany(p => p.AracVereceks)
                .HasForeignKey(d => d.AracTipi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AracAnlasmalar_AracTipleri");

            entity.HasOne(d => d.SirketNavigation).WithMany(p => p.AracVereceks)
                .HasForeignKey(d => d.Sirket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AracAnlasmalar_Sirketler");

            entity.HasOne(d => d.TurNavigation).WithMany(p => p.AracVereceks)
                .HasForeignKey(d => d.Tur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AracVerecek_Turlar");

            entity.HasOne(d => d.VerecekParaBirimiNavigation).WithMany(p => p.AracVereceks)
                .HasForeignKey(d => d.VerecekParaBirimi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AracAnlasmalar_ParaBirimleri");
        });

        modelBuilder.Entity<Bilet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Biletler_1");

            entity.ToTable("Bilet");

            entity.Property(e => e.Aciklama).HasMaxLength(1000);
            entity.Property(e => e.MusteriAd).HasMaxLength(100);
            entity.Property(e => e.MusteriAdres).HasMaxLength(1000);
            entity.Property(e => e.MusteriOdaNo).HasMaxLength(10);
            entity.Property(e => e.MusteriSoyad).HasMaxLength(100);
            entity.Property(e => e.MusteriTelNo).HasMaxLength(16);
            entity.Property(e => e.MusteriUyruk)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Paid)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PAID");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.PasSirketi).HasMaxLength(100);
            entity.Property(e => e.Rest)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REST");
            entity.Property(e => e.ServisSaati).HasPrecision(0);

            entity.HasOne(d => d.MusteriBolge).WithMany(p => p.Bilets)
                .HasForeignKey(d => d.MusteriBolgeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Biletler_Bolgeler");

            entity.HasOne(d => d.MusteriOtel).WithMany(p => p.Bilets)
                .HasForeignKey(d => d.MusteriOtelId)
                .HasConstraintName("FK_Biletler_Oteller");

            entity.HasOne(d => d.MusteriUyrukNavigation).WithMany(p => p.Bilets)
                .HasForeignKey(d => d.MusteriUyruk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Biletler_Uyruklar");

            entity.HasOne(d => d.ParaBirimiNavigation).WithMany(p => p.Bilets)
                .HasForeignKey(d => d.ParaBirimi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Biletler_ParaBirimleri");

            entity.HasOne(d => d.SatanEleman).WithMany(p => p.Bilets)
                .HasForeignKey(d => d.SatanElemanId)
                .HasConstraintName("FK_Biletler_Calisanlar");

            entity.HasOne(d => d.SatanSube).WithMany(p => p.Bilets)
                .HasForeignKey(d => d.SatanSubeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Biletler_Subeler");

            entity.HasOne(d => d.Tur).WithMany(p => p.BiletTurs)
                .HasForeignKey(d => d.TurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Biletler_Turlar");

            entity.HasOne(d => d.YeniTur).WithMany(p => p.BiletYeniTurs)
                .HasForeignKey(d => d.YeniTurId)
                .HasConstraintName("FK_Biletler_Turlar1");
        });

        modelBuilder.Entity<Bolge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Bolgeler");

            entity.ToTable("Bolge");

            entity.Property(e => e.BolgeIsim).HasMaxLength(50);
            entity.Property(e => e.ServisSaati).HasPrecision(0);
        });

        modelBuilder.Entity<BolgeOtel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BolgeOtel");

            entity.HasOne(d => d.Bolge).WithMany()
                .HasForeignKey(d => d.BolgeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BolgelerOteller_Bolgeler");

            entity.HasOne(d => d.Otel).WithMany()
                .HasForeignKey(d => d.OtelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BolgelerOteller_Oteller");
        });

        modelBuilder.Entity<BolgeSube>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BolgeSube");

            entity.HasOne(d => d.Bolge).WithMany()
                .HasForeignKey(d => d.BolgeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BolgelerSubeler_Bolgeler");

            entity.HasOne(d => d.Sube).WithMany()
                .HasForeignKey(d => d.SubeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BolgelerSubeler_Subeler");
        });

        modelBuilder.Entity<Calisan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Calisanlar");

            entity.ToTable("Calisan");

            entity.Property(e => e.CalisanAdi).HasMaxLength(100);
            entity.Property(e => e.CalisanMail).HasMaxLength(200);
            entity.Property(e => e.CalisanSifre)
                .HasMaxLength(64)
                .IsFixedLength();
            entity.Property(e => e.CalisanSoyadi).HasMaxLength(100);
            entity.Property(e => e.CalisanTelNo).HasMaxLength(16);
        });

        modelBuilder.Entity<Gelir>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gelirler");

            entity.ToTable("Gelir");

            entity.Property(e => e.Aciklama).HasMaxLength(1000);
            entity.Property(e => e.Miktar).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Kategori).WithMany(p => p.Gelirs)
                .HasForeignKey(d => d.KategoriId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gelirler_GelirGiderKategori");

            entity.HasOne(d => d.Tur).WithMany(p => p.Gelirs)
                .HasForeignKey(d => d.TurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gelirler_Turlar");
        });

        modelBuilder.Entity<GelirGiderKategori>(entity =>
        {
            entity.ToTable("GelirGiderKategori");

            entity.Property(e => e.KategoriAdi).HasMaxLength(100);
        });

        modelBuilder.Entity<Gider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Giderler");

            entity.ToTable("Gider");

            entity.Property(e => e.Aciklama).HasMaxLength(1000);
            entity.Property(e => e.Miktar).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Kategori).WithMany(p => p.Giders)
                .HasForeignKey(d => d.KategoriId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Giderler_GelirGiderKategori");

            entity.HasOne(d => d.Tur).WithMany(p => p.Giders)
                .HasForeignKey(d => d.TurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Giderler_Turlar");
        });

        modelBuilder.Entity<Gorev>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Gorevler");

            entity.ToTable("Gorev");

            entity.Property(e => e.Aciklama).HasMaxLength(1000);
            entity.Property(e => e.GorevAdi).HasMaxLength(100);
        });

        modelBuilder.Entity<GorevCalisan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GorevCalisan");

            entity.HasOne(d => d.Calisan).WithMany()
                .HasForeignKey(d => d.CalisanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GorevlerCalisanlar_Calisanlar");

            entity.HasOne(d => d.Gorev).WithMany()
                .HasForeignKey(d => d.GorevId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GorevlerCalisanlar_Gorevler");
        });

        modelBuilder.Entity<Kur>(entity =>
        {
            entity.HasKey(e => e.Tarih).HasName("PK_Kurlar");

            entity.ToTable("Kur");

            entity.Property(e => e.DolaraOran).HasColumnType("decimal(18, 17)");
            entity.Property(e => e.EuroyaOran).HasColumnType("decimal(18, 17)");
            entity.Property(e => e.ParaBirimiAdi)
                .HasMaxLength(3)
                .IsFixedLength();

            entity.HasOne(d => d.ParaBirimiAdiNavigation).WithMany(p => p.Kurs)
                .HasForeignKey(d => d.ParaBirimiAdi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Kurlar_ParaBirimleri");
        });

        modelBuilder.Entity<Otel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Oteller");

            entity.ToTable("Otel");

            entity.Property(e => e.OtelIsim).HasMaxLength(500);
        });

        modelBuilder.Entity<ParaBirimi>(entity =>
        {
            entity.HasKey(e => e.Iso4217).HasName("PK_ParaBirimleri");

            entity.ToTable("ParaBirimi");

            entity.Property(e => e.Iso4217)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("ISO4217");
            entity.Property(e => e.ParaBirimiAdi).HasMaxLength(100);
        });

        modelBuilder.Entity<PasAlacak>(entity =>
        {
            entity.ToTable("PasAlacak");

            entity.Property(e => e.AlacakParaBirimi)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.OdenenAlacak).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ToplamAlacak).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AlacakParaBirimiNavigation).WithMany(p => p.PasAlacaks)
                .HasForeignKey(d => d.AlacakParaBirimi)
                .HasConstraintName("FK_PasAlacak_ParaBirimleri");

            entity.HasOne(d => d.BiletNavigation).WithMany(p => p.PasAlacaks)
                .HasForeignKey(d => d.Bilet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PasAlacak_Biletler");

            entity.HasOne(d => d.SirketNavigation).WithMany(p => p.PasAlacaks)
                .HasForeignKey(d => d.Sirket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PasAlacak_Sirketler");
        });

        modelBuilder.Entity<PasAnlasma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PasAnlasmalar");

            entity.ToTable("PasAnlasma");

            entity.Property(e => e.AlacakParaBirimi)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.VerecekParaBirimi)
                .HasMaxLength(3)
                .IsFixedLength();

            entity.HasOne(d => d.AlacakParaBirimiNavigation).WithMany(p => p.PasAnlasmaAlacakParaBirimiNavigations)
                .HasForeignKey(d => d.AlacakParaBirimi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PasAnlasmalar_ParaBirimleri");

            entity.HasOne(d => d.SirketNavigation).WithMany(p => p.PasAnlasmas)
                .HasForeignKey(d => d.Sirket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PasAnlasmalar_Sirketler");

            entity.HasOne(d => d.VerecekParaBirimiNavigation).WithMany(p => p.PasAnlasmaVerecekParaBirimiNavigations)
                .HasForeignKey(d => d.VerecekParaBirimi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PasAnlasmalar_ParaBirimleri1");
        });

        modelBuilder.Entity<PasVerecek>(entity =>
        {
            entity.ToTable("PasVerecek");

            entity.Property(e => e.OdenenVerecek).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ToplamVerecek).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VerecekParaBirimi)
                .HasMaxLength(3)
                .IsFixedLength();

            entity.HasOne(d => d.BiletNavigation).WithMany(p => p.PasVereceks)
                .HasForeignKey(d => d.Bilet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PasVerecek_Biletler");

            entity.HasOne(d => d.SirketNavigation).WithMany(p => p.PasVereceks)
                .HasForeignKey(d => d.Sirket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PasVerecek_Sirketler");

            entity.HasOne(d => d.VerecekParaBirimiNavigation).WithMany(p => p.PasVereceks)
                .HasForeignKey(d => d.VerecekParaBirimi)
                .HasConstraintName("FK_PasVerecek_ParaBirimleri");
        });

        modelBuilder.Entity<SirketTurTipi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SirketTurTipi");

            entity.HasOne(d => d.Sirket).WithMany()
                .HasForeignKey(d => d.SirketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirketlerTurTipleri_Sirketler");

            entity.HasOne(d => d.TurTipi).WithMany()
                .HasForeignKey(d => d.TurTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SirketlerTurTipleri_TurTipleri");
        });

        modelBuilder.Entity<Sirket>(entity =>
        {
            entity.ToTable("Sirketler");

            entity.Property(e => e.SirketAdi).HasMaxLength(150);
            entity.Property(e => e.SirketGirisAdi).HasMaxLength(50);
            entity.Property(e => e.SirketMail).HasMaxLength(100);
            entity.Property(e => e.SirketSifre)
                .HasMaxLength(64)
                .IsFixedLength();
            entity.Property(e => e.SirketTelNo).HasMaxLength(16);
        });

        modelBuilder.Entity<Sube>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Subeler");

            entity.ToTable("Sube");

            entity.Property(e => e.SubeAd).HasMaxLength(100);
        });

        modelBuilder.Entity<SubeCalisan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SubeCalisan");

            entity.HasOne(d => d.Calisan).WithMany()
                .HasForeignKey(d => d.CalisanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubelerCalisanlar_Calisanlar");

            entity.HasOne(d => d.Sube).WithMany()
                .HasForeignKey(d => d.SubeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubelerCalisanlar_Subeler");
        });

        modelBuilder.Entity<Tur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Turlar");

            entity.ToTable("Tur");

            entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Saat).HasPrecision(0);

            entity.HasOne(d => d.TurTipi).WithMany(p => p.Turs)
                .HasForeignKey(d => d.TurTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turlar_TurTipleri");
        });

        modelBuilder.Entity<TurTipi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TurTipleri");

            entity.ToTable("TurTipi");

            entity.Property(e => e.TurTipiAdi).HasMaxLength(100);

            entity.HasOne(d => d.AracTipi).WithMany(p => p.TurTipis)
                .HasForeignKey(d => d.AracTipiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TurTipleri_AracTipleri");
        });

        modelBuilder.Entity<Uyruk>(entity =>
        {
            entity.HasKey(e => e.Alpha3Code).HasName("PK_Uyruklar");

            entity.ToTable("Uyruk");

            entity.Property(e => e.Alpha3Code)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.UlkeIsmi).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
