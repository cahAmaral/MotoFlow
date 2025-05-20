using Microsoft.EntityFrameworkCore;
using ControlePatioAPI.Models;

namespace ControlePatioAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Moto> Motos { get; set; }
    }
}
