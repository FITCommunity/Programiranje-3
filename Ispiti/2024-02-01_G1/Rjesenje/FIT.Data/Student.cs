using FIT.Data.IspitBrojIndeksa;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public int SemestarId { get; set; }
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }

        // Stuff I added below

        public GradoviBrojIndeksa Grad { get; set; } = null!;

        [NotMapped]
        public DrzaveBrojIndeksa Drzava => Grad.Drzava;

        [NotMapped]
        public double Prosjek => PolozeniPredmeti.Count == 0 ? 5 : PolozeniPredmeti.Average(polozeniPredmet => polozeniPredmet.Ocjena);

        public List<PolozeniPredmetiBrojIndeksa> PolozeniPredmeti = new();
    }
}
