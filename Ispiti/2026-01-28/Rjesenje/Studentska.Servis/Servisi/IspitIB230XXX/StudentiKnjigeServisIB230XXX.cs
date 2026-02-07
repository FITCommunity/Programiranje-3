using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IspitIB230XXX;

namespace Studentska.Servis.Servisi.IspitIB230XXX;


public sealed class StudentiKnjigeServisIB230XXX : BaseServis<StudentiKnjigeIB230XXX>
{
    public List<StudentiKnjigeIB230XXX> GetAllIznajmljivanjaForStudent(int studentId)
    {
        var iznajmljivanja = _dbContext.StudentiKnjige
                                       .Include(studentiKnjige => studentiKnjige.Knjiga)
                                       .Where(studentiKnjige => studentiKnjige.StudentId == studentId)
                                       .ToList();

        return iznajmljivanja;
    }

    public List<StudentiKnjigeIB230XXX> GetAllIznajmljivanja()
    {
        var iznajmljivanja = _dbContext.StudentiKnjige
                                       .Include(studentiKnjige => studentiKnjige.Student)
                                       .Include(studentiKnjige => studentiKnjige.Knjiga)
                                       .ToList();

        return iznajmljivanja;
    }

    public List<StudentiKnjigeIB230XXX> GetIznajmljivanjaForFilter(string imePrezimeIliNazivKnjige, bool vracena)
    {
        var iznajmljivanja = _dbContext.StudentiKnjige
                                       .Include(studentiKnjige => studentiKnjige.Student)
                                       .Include(studentiKnjige => studentiKnjige.Knjiga)
                                       .Where(studentiKnjige => 
                                            (studentiKnjige.Student.Ime.ToLower().Contains(imePrezimeIliNazivKnjige) 
                                         || studentiKnjige.Student.Prezime.ToLower().Contains(imePrezimeIliNazivKnjige)
                                         || studentiKnjige.Knjiga.Naziv.ToLower().Contains(imePrezimeIliNazivKnjige))
                                         && ((studentiKnjige.DatumVracanja != null) == vracena)
                                        )
                                       .ToList();

        return iznajmljivanja;
    }

    public void IznajmiKnjiguZaStudenta(int knjigaId, int studentId)
    {
        var studentKnjiga = new StudentiKnjigeIB230XXX
        {
            StudentId = studentId,
            KnjigaId = knjigaId,
            DatumIznajmljivanja = DateTime.Now
        };

        Add(studentKnjiga);
    }

    public bool DaLiJeStudentIznajmioKnjigu(int knjigaId, int studentId)
    {
        return _dbContext.StudentiKnjige.Any(studentKnjiga => 
                        studentKnjiga.StudentId == studentId 
                     && studentKnjiga.KnjigaId == knjigaId 
                     && studentKnjiga.DatumVracanja == null
                     );
    }

    public void PovratiKnjigu(int studentKnjigaId)
    {
        var studentKnjiga = GetById(studentKnjigaId);

        if (studentKnjiga is null)
        {
            System.Diagnostics.Debug.WriteLine($"StudentKnjiga for id {studentKnjigaId} was not found");
            return;
        }

        studentKnjiga.DatumVracanja = studentKnjiga.Vracena ? null : DateTime.Now;

        _dbContext.SaveChanges();
    }

    public bool DaLiJeBrojPrimjerakaNaStanu(int knjigaId)
    {
        using var knjigaServis = new KnjigeServisIB230XXX();
        var knjiga = knjigaServis.GetById(knjigaId);

        if (knjiga is null)
        {
            System.Diagnostics.Debug.WriteLine($"Knjiga for id {knjigaId} was not found");
            return false;
        }

        var brojIzdatihTrenutno = _dbContext.StudentiKnjige.Count(studentKnjiga => studentKnjiga.KnjigaId == knjigaId && studentKnjiga.DatumVracanja == null);

        return brojIzdatihTrenutno < knjiga.BrojPrimjeraka;
    }

    public List<int> GetKnjigeIdForStudentWhichIznajmljenje(int studentId)
    {
        using var knjigaServis = new KnjigeServisIB230XXX();

        var sveKnjigeIds = knjigaServis.GetAllKnjigeId();
        var iznajmljeneKnjigeIds = _dbContext.StudentiKnjige.Where(studentKnjiga => studentKnjiga.StudentId == studentId && studentKnjiga.DatumVracanja == null)
                                                           .Select(studentKnjiga => studentKnjiga.KnjigaId)
                                                           .ToList();

        var neiznajmljeneKnjigeIds = sveKnjigeIds.Where(knjigaId => !iznajmljeneKnjigeIds.Contains(knjigaId)).ToList();

        return neiznajmljeneKnjigeIds;
    }
}
