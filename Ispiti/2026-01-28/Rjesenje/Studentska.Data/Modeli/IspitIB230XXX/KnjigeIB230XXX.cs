using System.ComponentModel.DataAnnotations.Schema;

namespace Studentska.Data.Modeli.IspitIB230XXX;

[Table("KnjigeIB230XXX")]
public sealed class KnjigeIB230XXX
{
    public int Id { get; set; }
    public string Naziv { get; set; } = "";
	public string Autor { get; set; } = "";
	public int BrojPrimjeraka { get; set; }
    public byte[] Slika { get; set; } = null!;

    public string NazivIAutor => $"{Naziv} ({Autor})";
}
