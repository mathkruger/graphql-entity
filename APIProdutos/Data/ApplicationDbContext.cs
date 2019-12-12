using Microsoft.EntityFrameworkCore;
using APIProdutos.Models;

namespace APIProdutos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :
            base(options) { }

        public DbSet<Estpro> Estpro { get; set; }
        public DbSet<Rodfab> Rodfab { get; set; }
        public DbSet<Rodfil> Rodfil { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}