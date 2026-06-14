using Microsoft.EntityFrameworkCore;
using GestionMascotas.Data;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllersWithViews();

// EF Core SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
