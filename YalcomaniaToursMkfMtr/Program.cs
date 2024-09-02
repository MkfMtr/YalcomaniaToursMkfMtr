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

builder.Services.AddControllersWithViews();
builder.Services.AddScoped < IGenericRepository<Tur>, GenericRepository<Tur> >();
builder.Services.AddScoped < IGenericRepository<AracVerecek>, GenericRepository<AracVerecek> >();

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
