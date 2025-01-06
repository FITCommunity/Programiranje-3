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
        public DbSet<DrzaveBrojIndeksa> Drzave => Set<DrzaveBrojIndeksa>();
        public DbSet<GradoviBrojIndeksa> Gradovi => Set<GradoviBrojIndeksa>();
        public DbSet<PolozeniPredmetiBrojIndeksa> PolozeniPredmeti => Set<PolozeniPredmetiBrojIndeksa>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DrzaveBrojIndeksa>()
                        .HasMany(drzava => drzava.Gradovi)
                        .WithOne(grad => grad.Drzava);

            modelBuilder.Entity<Student>()
                        .HasMany(student => student.PolozeniPredmeti)
                        .WithOne(polozeniPredmeti => polozeniPredmeti.Student);
        }
    }
}