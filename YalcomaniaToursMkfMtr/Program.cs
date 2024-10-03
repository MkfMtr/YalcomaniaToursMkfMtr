using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<YalcoContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(2);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddControllersWithViews();

//Dependency Injection
builder.Services.AddScoped<ITurService, TurService>();
builder.Services.AddScoped<IGenericRepository<Tur>, GenericRepository<Tur>>();
builder.Services.AddScoped<IAracService, AracService>();
builder.Services.AddScoped<IGenericRepository<Arac>, GenericRepository<Arac>>();
builder.Services.AddScoped<IAracTipiService, AracTipiService>();
builder.Services.AddScoped<IGenericRepository<AracTipi>, GenericRepository<AracTipi>>();
builder.Services.AddScoped<IBiletService, BiletService>();
builder.Services.AddScoped<IGenericRepository<Bilet>, GenericRepository<Bilet>>();
builder.Services.AddScoped<IBolgeService, BolgeService>();
builder.Services.AddScoped<IGenericRepository<Bolge>, GenericRepository<Bolge>>();
builder.Services.AddScoped<IBolgeOtelService, BolgeOtelService>();
builder.Services.AddScoped<IGenericRepository<BolgeOtel>, GenericRepository<BolgeOtel>>();
builder.Services.AddScoped<IBolgeSubeService, BolgeSubeService>();
builder.Services.AddScoped<IGenericRepository<BolgeSube>, GenericRepository<BolgeSube>>();
builder.Services.AddScoped<ICalisanService, CalisanService>();
builder.Services.AddScoped<IGenericRepository<Calisan>, GenericRepository<Calisan>>();
builder.Services.AddScoped<IGorevService, GorevService>();
builder.Services.AddScoped<IGenericRepository<Gorev>, GenericRepository<Gorev>>();
builder.Services.AddScoped<IGorevCalisanService, GorevCalisanService>();
builder.Services.AddScoped<IGenericRepository<GorevCalisan>, GenericRepository<GorevCalisan>>();
builder.Services.AddScoped<IKurService, KurService>();
builder.Services.AddScoped<IGenericRepository<Kur>, GenericRepository<Kur>>();
builder.Services.AddScoped<IOtelService, OtelService>();
builder.Services.AddScoped<IGenericRepository<Otel>, GenericRepository<Otel>>();
builder.Services.AddScoped<IParaBirimiService, ParaBirimiService>();
builder.Services.AddScoped<IGenericRepository<ParaBirimi>, GenericRepository<ParaBirimi>>();
builder.Services.AddScoped<ISirketService, SirketService>();
builder.Services.AddScoped<IGenericRepository<Sirket>, GenericRepository<Sirket>>();
builder.Services.AddScoped<ISirketTurTipiService, SirketTurTipiService>();
builder.Services.AddScoped<IGenericRepository<SirketTurTipi>, GenericRepository<SirketTurTipi>>();
builder.Services.AddScoped<ISubeService, SubeService>();
builder.Services.AddScoped<IGenericRepository<Sube>, GenericRepository<Sube>>();
builder.Services.AddScoped<ISubeCalisanService, SubeCalisanService>();
builder.Services.AddScoped<IGenericRepository<SubeCalisan>, GenericRepository<SubeCalisan>>();
builder.Services.AddScoped<ITurTipiService, TurTipiService>();
builder.Services.AddScoped<IGenericRepository<TurTipi>, GenericRepository<TurTipi>>();
builder.Services.AddScoped<IUyrukService, UyrukService>();
builder.Services.AddScoped<IGenericRepository<Uyruk>, GenericRepository<Uyruk>>();

var app = builder.Build();

// Check if the database is created and if not, create one.
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<YalcoContext>();
    dbContext.Database.EnsureCreated();

    #region Seeds
    // Check if the tables are empty and if so, seed them.
    if (!dbContext.Gorevler.Any())
    {
        await dbContext.Gorevler.AddRangeAsync(GorevSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.Calisanlar.Any())
    {
        await dbContext.Calisanlar.AddRangeAsync(CalisanSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.GorevlerCalisanlar.Any())
    {
        await dbContext.GorevlerCalisanlar.AddRangeAsync(GorevCalisanSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.ParaBirimleri.Any())
    {
        await dbContext.ParaBirimleri.AddRangeAsync(ParaBirimiSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.Subeler.Any())
    {
        await dbContext.Subeler.AddRangeAsync(SubeSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.Bolgeler.Any())
    {
        await dbContext.Bolgeler.AddRangeAsync(BolgeSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.BolgelerSubeler.Any())
    {
        await dbContext.BolgelerSubeler.AddRangeAsync(BolgeSubeSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.Sirketler.Any())
    {
        await dbContext.Sirketler.AddRangeAsync(SirketSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.SubelerCalisanlar.Any())
    {
        await dbContext.SubelerCalisanlar.AddRangeAsync(SubeCalisanSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.Oteller.Any())
    {
        await dbContext.Oteller.AddRangeAsync(OtelSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.BolgelerOteller.Any())
    {
        await dbContext.BolgelerOteller.AddRangeAsync(BolgeOtelSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.AracTipleri.Any())
    {
        await dbContext.AracTipleri.AddRangeAsync(AracTipiSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.Uyruklar.Any())
    {
        await dbContext.Uyruklar.AddRangeAsync(UyrukSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.Araclar.Any())
    {
        await dbContext.Araclar.AddRangeAsync(AracSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.TurTipleri.Any())
    {
        await dbContext.TurTipleri.AddRangeAsync(TurTipiSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.SirketTurTipleri.Any())
    {
        await dbContext.SirketTurTipleri.AddRangeAsync(SirketTurTipiSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.GelirGiderKategoriler.Any())
    {
        await dbContext.GelirGiderKategoriler.AddRangeAsync(GelirGiderKategoriSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }

    if (!dbContext.PasAnlasmalar.Any())
    {
        await dbContext.PasAnlasmalar.AddRangeAsync(PasAnlasmaSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }
    if (!dbContext.Kurlar.Any())
    {
        await dbContext.Kurlar.AddRangeAsync(KurSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }
    if (!dbContext.Turlar.Any())
    {
        await dbContext.Turlar.AddRangeAsync(TurSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }
    if (!dbContext.Biletler.Any())
    {
        await dbContext.Biletler.AddRangeAsync(BiletSeed.GetSeeds());
        await dbContext.SaveChangesAsync();
    }
    #endregion
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");


app.Run();
