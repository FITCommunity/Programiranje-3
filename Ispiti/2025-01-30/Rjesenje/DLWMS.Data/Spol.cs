using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    [Table("SpolBrojIndeksa")]
    public class Spol
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivan { get; set; }

        // Stuff I added below

        public List<Student> Studenti = new();
        public override string ToString() => Naziv;
    }
}