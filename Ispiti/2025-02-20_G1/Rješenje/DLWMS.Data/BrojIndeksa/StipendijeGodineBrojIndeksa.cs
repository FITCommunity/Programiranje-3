using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230269
{
    public class StipendijeGodineBrojIndeksa
    {
        public int Id { get; set; }
        public string Godina { get; set; }
        public int StipendijaId { get; set; }
        public StipendijeBrojIndeksa Stipendija { get; set; }
        public int Iznos { get; set; }
        public bool Aktivna { get; set; }
        [NotMapped] public string Naziv => Stipendija.Naziv;
        [NotMapped] public int Ukupno => (Godina == DateTime.Now.Year.ToString() ? DateTime.Now.Month : 12) * Iznos;
    }
}
