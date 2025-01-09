using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }

        // Stuff I added below

        public DbSet<ProstorijeBrojIndeksa> Prostorije => Set<ProstorijeBrojIndeksa>();
        public DbSet<NastavaBrojIndeksa> Nastave => Set<NastavaBrojIndeksa>();
        public DbSet<PredmetiBrojIndeksa> Predmeti => Set<PredmetiBrojIndeksa>();
        public DbSet<PrisustvoBrojIndeksa> Prisustvo => Set<PrisustvoBrojIndeksa>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProstorijeBrojIndeksa>()
                        .HasMany(prostorija => prostorija.Predmeti)
                        .WithMany(predmet => predmet.Prostorije)
                        .UsingEntity<NastavaBrojIndeksa>();
        }
    }
}