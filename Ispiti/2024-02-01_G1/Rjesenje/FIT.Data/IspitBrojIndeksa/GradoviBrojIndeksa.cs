using System.ComponentModel.DataAnnotations.Schema;

namespace FIT.Data.IspitBrojIndeksa
{
    [Table("GradoviBrojIndeksa")]
    public class GradoviBrojIndeksa
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = "";
        public bool Status { get; set; }
        public DrzaveBrojIndeksa Drzava { get; set; } = null!;

        public override string ToString() => Naziv;

    }
}
