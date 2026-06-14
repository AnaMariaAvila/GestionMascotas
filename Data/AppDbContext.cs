using Microsoft.EntityFrameworkCore;
using GestionMascotas.Models;

namespace GestionMascotas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mascota> Mascotas { get; set; }
    }
}