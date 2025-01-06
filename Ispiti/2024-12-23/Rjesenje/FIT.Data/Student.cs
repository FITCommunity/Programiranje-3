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
       
        [NotMapped]
        public int Age 
        {
            get 
            {
                DateTime birthDate = DatumRodjenja;
                DateTime today = DateTime.Now;

                int years = today.Year - birthDate.Year;

                if (birthDate.AddYears(years) < today)
                {
                    --years;
                }

                return years;
            }
        }

        [NotMapped]
        public string ImePrezimeGodine => $"{Ime} {Prezime}({Age})";        
        
        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";

        public SemestriBrojIndeksa Semestar { get; set; } = null!;

        public UlogeBrojIndeksa Uloga { get; set; } = null!;

        public List<PolozeniPredmetiBrojIndeksa> PolozeniPredmeti = new();
        
        [NotMapped]
        public double Prosjek => PolozeniPredmeti.Count == 0 ? 5 : PolozeniPredmeti.Average(polozeniPredmet => polozeniPredmet.Ocjena);

        public List<StudentiPorukeBrojIndeksa> Poruke = new();

        [NotMapped]
        public int BrojPoruka => Poruke.Count;
    }
}
