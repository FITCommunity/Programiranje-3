using System.ComponentModel.DataAnnotations.Schema;

namespace FIT.Data.IspitBrojIndeksa
{
    [Table("StudentiPorukeBrojIndeksa")]
    public class StudentiPorukeBrojIndeksa
    {
        public int Id { get; set; }
        public Student Student { get; set; } = null!;
	    public PredmetiBrojIndeksa Predmet { get; set; } = null!;
	    public DateTime Validnost { get; set; }
        public string Sadrzaj { get; set; } = "";
	    public string Hitnost { get; set; } = "";
        public byte[] Slika { get; set; } = null!;
    }
}
