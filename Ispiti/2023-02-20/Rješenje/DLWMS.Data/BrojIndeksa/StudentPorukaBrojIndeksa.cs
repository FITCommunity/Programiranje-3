using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.BrojIndeksa
{
    [Table("StudentiPorukeBrojIndeksa")]
    public class StudentPorukaBrojIndeksa
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public PredmetBrojIndeksa Predmet { get; set; }
        public DateTime Validnost { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
    }
}
