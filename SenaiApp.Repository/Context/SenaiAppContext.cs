using Microsoft.EntityFrameworkCore;
using SenaiApp.Domain.Entidade;

namespace SenaiApp.Repository.Context
{
    public class SenaiAppContext : DbContext
    {
        public SenaiAppContext(DbContextOptions<SenaiAppContext> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}

