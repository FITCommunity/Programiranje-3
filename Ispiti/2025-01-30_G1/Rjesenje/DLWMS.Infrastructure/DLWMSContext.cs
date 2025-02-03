using DLWMS.Data;
using DLWMS.Data.IspitBrojIndeksa;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<Student> Studenti { get; set; }

        // Stuff I added below

        public DbSet<Drzava> Drzave => Set<Drzava>();
        public DbSet<Grad> Gradovi => Set<Grad>();
        public DbSet<Spol> Spolovi => Set<Spol>();
        public DbSet<UniverzitetBrojIndeksa> Univerziteti => Set<UniverzitetBrojIndeksa>();
        public DbSet<RazmjeneBrojIndeksa> Razmjene => Set<RazmjeneBrojIndeksa>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>()
                        .HasMany(drzava => drzava.Gradovi)
                        .WithOne(grad => grad.Drzava);

            modelBuilder.Entity<Drzava>()
                        .HasMany(drzava => drzava.Univerziteti)
                        .WithOne(univerzitet => univerzitet.Drzava);

            modelBuilder.Entity<Spol>()
                        .HasMany(spol => spol.Studenti)
                        .WithOne(student => student.Spol);

            modelBuilder.Entity<Student>()
                        .HasMany(student => student.Razmjene)
                        .WithOne(razmjena => razmjena.Student);
        }
    }
}
