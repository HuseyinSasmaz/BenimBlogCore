using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models.Entity
{
    public class Calısan
    {
        [Key]
        public int CalısanID { get; set; }
        public string CalısanAdı { get; set; }
    }
}
