using Studentska.Data.Entiteti;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studentska.Data.Modeli.IspitIB230XXX;

[Table("StudentiKnjigeIB230XXX")]
public sealed class StudentiKnjigeIB230XXX
{
    public int Id { get; set; }
	public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
	public int KnjigaId { get; set; }
    public KnjigeIB230XXX Knjiga { get; set; } = null!;
	public DateTime DatumIznajmljivanja { get; set; }
	public DateTime? DatumVracanja { get; set; }

    public string StudentIndeksImePrezime => Student.IndeksImePrezime;
    public string NazivKnjige => Knjiga.Naziv;
    public bool Vracena => DatumVracanja is not null;

    public int BrojDanaIzdato => (int)Math.Round(((DatumVracanja ?? DateTime.Now) - DatumIznajmljivanja).TotalDays);
}
