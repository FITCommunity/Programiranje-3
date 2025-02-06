using DLWMS.Data;
using DLWMS.Data.IB200234;
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
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<AkademskaGodina> AkademskeGodine { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<UniverzitetiIB200234> UniverzitetiIB200234 { get; set; }
        public DbSet<RazmjeneIB200234> RazmjeneIB200234 { get; set; }


    }
}
