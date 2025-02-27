using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public int GradId { get; set; }
        public int SpolId { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }

        // Stuff I added below

        public string ImePrezime => $"{Ime} {Prezime}";
        public string IndeksImePrezime => $"({BrojIndeksa}) {ImePrezime}";
        public override string ToString() => IndeksImePrezime;
    }
}