using System.ComponentModel.DataAnnotations.Schema;

namespace FIT.Data.IspitBrojIndeksa
{
    [Table("DrzaveBrojIndeksa")]
    public class DrzaveBrojIndeksa
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = "";
	    public bool Status { get; set; }
        public byte[] Zastava { get; set; } = null!;

        [NotMapped]
        public int BrojGradova => Gradovi.Count;

        public List<GradoviBrojIndeksa> Gradovi = new();

        public override string ToString() => Naziv;
    }
}
