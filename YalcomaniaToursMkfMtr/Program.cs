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

    if (!dbContext.Gorevler.Any())
    {
        dbContext.Gorevler.AddRange(GorevSeed.GetSeedData());
    }

    if (!dbContext.Calisanlar.Any())
    {
        dbContext.Calisanlar.AddRange(CalisanSeed.GetCalisanSeeds());
    }

    if (!dbContext.GorevlerCalisanlar.Any())
    {
        dbContext.GorevlerCalisanlar.AddRange(GorevCalisanSeed.SeedData());
    }

    dbContext.SaveChanges();
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
