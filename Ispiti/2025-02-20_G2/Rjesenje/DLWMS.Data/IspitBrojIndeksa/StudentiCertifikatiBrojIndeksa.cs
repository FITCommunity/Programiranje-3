using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data.IspitBrojIndeksa
{
    [Table("StudentiCertifikatiBrojIndeksa")]
    public class StudentiCertifikatiBrojIndeksa
    {
        public int Id { get; set; }
        public Student Student { get; set; } = null!;
	    public CertifikatiGodineBrojIndeksa CertifikatGodina { get; set; } = null!;

        public int MjesecniIznos => CertifikatGodina.MjesecniIznos;
        public int UkupniIznos => CertifikatGodina.UkupniIznos;
        public int Godina => CertifikatGodina.Godina;
    }
}
