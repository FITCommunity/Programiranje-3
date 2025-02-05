using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB200234
{
    public class RazmjeneIB200234
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int UniverzitetId { get; set; }
        public UniverzitetiIB200234 Univerzitet { get; set; }
        public string UniverzitetDrzava => Univerzitet.UniverzitetDrzava;
        public DateTime PocetakRazmjene { get; set; }
        public DateTime KrajRazmjene { get; set; }
        public int Kredit { get; set; }
        public bool Okoncana { get; set; }

    }
}
