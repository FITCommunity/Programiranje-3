using DLWMS.Data;
using DLWMS.Data.IB230269;
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
        public DbSet<StipendijeBrojIndeksa> StipendijeBrojIndeksa { get; set; }
        public DbSet<StipendijeGodineBrojIndeksa> StipendijeGodineBrojIndeksa { get; set; }
        public DbSet<StudentiStipendijeBrojIndeksa> StudentiStipendijeBrojIndeksa { get; set; }
    }
}
