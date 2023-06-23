using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.BrojIndeksa
{
    [Table("StudentiPredmeti")]
    public class StudentPredmetBrojIndeksa
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public PredmetBrojIndeksa Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }

    }
}
