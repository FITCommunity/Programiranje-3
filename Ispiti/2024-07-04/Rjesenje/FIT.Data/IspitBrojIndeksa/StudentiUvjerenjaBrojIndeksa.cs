using System.ComponentModel.DataAnnotations.Schema;

namespace FIT.Data.IspitBrojIndeksa
{
    [Table("StudentiUvjerenjaBrojIndeksa")]
    public class StudentiUvjerenjaBrojIndeksa
    {
        public int Id { get; set; }
        public Student Student { get; set; } = null!;
	    public DateTime VrijemeKreiranja { get; set; }
        public string Vrsta { get; set; } = "";
	    public string Svrha { get; set; } = "";
        public byte[] Uplatnica { get; set; } = null!;
	    public bool Printano { get; set; }
    }
}
