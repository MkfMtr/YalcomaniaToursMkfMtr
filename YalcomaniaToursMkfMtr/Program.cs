using DataAccessLayer.Context;
using DataAccessLayer.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<YalcoContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();

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
        dbContext.Gorevler.AddRange(GorevSeed.GetSeeds());
    }

    if (!dbContext.Calisanlar.Any())
    {
        dbContext.Calisanlar.AddRange(CalisanSeed.GetSeeds());
    }

    if (!dbContext.GorevlerCalisanlar.Any())
    {
        dbContext.GorevlerCalisanlar.AddRange(GorevCalisanSeed.GetSeeds());
    }

    if (!dbContext.ParaBirimleri.Any())
    {
        dbContext.ParaBirimleri.AddRange(ParaBirimiSeed.GetSeeds());
    }

    if (!dbContext.Subeler.Any())
    {
        dbContext.Subeler.AddRange(SubeSeed.GetSeeds());
    }

    if (!dbContext.Bolgeler.Any())
    {
        dbContext.Bolgeler.AddRange(BolgeSeed.GetSeeds());
    }

    if (!dbContext.BolgelerSubeler.Any())
    {
        dbContext.BolgelerSubeler.AddRange(BolgeSubeSeed.GetSeeds());
    }

    if (!dbContext.ParaBirimleri.Any())
    {
        dbContext.ParaBirimleri.AddRange(ParaBirimiSeed.GetSeeds());
    }

    if (!dbContext.Sirketler.Any())
    {
        dbContext.Sirketler.AddRange(SirketSeed.GetSeeds());
    }

    if (!dbContext.SubelerCalisanlar.Any())
    {
        dbContext.SubelerCalisanlar.AddRange(SubeCalisanSeed.GetSeeds());
    }

    if (!dbContext.Oteller.Any())
    {
        dbContext.Oteller.AddRange(OtelSeed.GetSeeds());
    }

    if (!dbContext.BolgelerOteller.Any())
    {
        dbContext.BolgelerOteller.AddRange(BolgeOtelSeed.GetSeeds());
    }

    if (!dbContext.Uyruklar.Any())
    {
        dbContext.Uyruklar.AddRange(UyrukSeed.GetSeeds());
    }

    if (!dbContext.AracTipleri.Any())
    {
        dbContext.AracTipleri.AddRange(AracTipiSeed.GetSeeds());
    }

    if (!dbContext.Araclar.Any())
    {
        dbContext.Araclar.AddRange(AracSeed.GetSeeds());
    }

    if (!dbContext.TurTipleri.Any())
    {
        dbContext.TurTipleri.AddRange(TurTipiSeed.GetSeeds());
    }
    
    if (!dbContext.SirketTurTipleri.Any())
    {
        dbContext.SirketTurTipleri.AddRange(SirketTurTipiSeed.GetSeeds());
    }
    
    if (!dbContext.GelirGiderKategoriler.Any())
    {
        dbContext.GelirGiderKategoriler.AddRange(GelirGiderKategoriSeed.GetSeeds());
    }
    
    if (!dbContext.PasAnlasmalar.Any()) 
    {
        dbContext.PasAnlasmalar.AddRange(PasAnlasmaSeed.GetSeeds());
    }

    dbContext.SaveChanges();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");


app.Run();
