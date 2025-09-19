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

        public DbSet<StipendijeBrojIndeksa> Stipendije { get; set; }
        public DbSet<StipendijeGodineBrojIndeksa> StipendijeGodine { get; set; }
        public DbSet<StudentiStipendijeBrojIndeksa> StudentiStipendije { get; set; }


    }
}
