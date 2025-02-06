using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB200234
{
    public class UniverzitetiIB200234
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }

        public string UniverzitetDrzava => $"{Naziv} ({Drzava})"; 
        public override string ToString()
        {
            return Naziv;
        }
    }
}
