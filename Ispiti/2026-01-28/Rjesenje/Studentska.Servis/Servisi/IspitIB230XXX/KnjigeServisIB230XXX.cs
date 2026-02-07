using Studentska.Data.Modeli.IspitIB230XXX;

namespace Studentska.Servis.Servisi.IspitIB230XXX;

public sealed class KnjigeServisIB230XXX : BaseServis<KnjigeIB230XXX>
{
    public bool DoesKnjigaExist(string nazivKnjige, string nazivAutora)
    {
        return _dbContext.Knjige.Any(knjiga => knjiga.Naziv == nazivKnjige && knjiga.Autor == nazivAutora);
    }

    public void Edit(int knjigaId, KnjigeIB230XXX knjigaData)
    {
        var knjiga = GetById(knjigaId);

        if (knjiga is null)
        {
            System.Diagnostics.Debug.WriteLine($"Knjiga za id {knjigaId} ne postoji");
            return;
        }

        knjiga.Naziv = knjigaData.Naziv;
        knjiga.Autor = knjigaData.Autor;
        knjiga.BrojPrimjeraka = knjigaData.BrojPrimjeraka;
        knjiga.Slika = knjigaData.Slika;

        _dbContext.SaveChanges();
    }

    internal List<int> GetAllKnjigeId()
    {
        return _dbContext.Knjige.Select(knjiga => knjiga.Id).ToList();
    }
}
