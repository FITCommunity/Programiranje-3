using System.ComponentModel.DataAnnotations.Schema;

namespace FIT.Data.IspitBrojIndeksa
{
    [Table("PrisustvoBrojIndeksa")]
    public class PrisustvoBrojIndeksa
    {
        public int Id { get; set; }
        public Student Student { get; set; } = null!;
        public NastavaBrojIndeksa Nastava { get; set; } = null!;
    }
}
