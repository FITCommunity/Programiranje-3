using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace DLWMS.Data.IspitBrojIndeksa
{
    [Table("RazmjeneBrojIndeksa")]
    public class RazmjeneBrojIndeksa
    {
        public int Id { get; set; }
        public Student Student { get; set; } = null!;
	    public UniverzitetBrojIndeksa Univerzitet { get; set; } = null!;
	    public DateTime Pocetak { get; set; }
	    public DateTime Kraj { get; set; }
	    public int ECTS { get; set; }
	    public bool Okoncano { get; set; }
    }
}
