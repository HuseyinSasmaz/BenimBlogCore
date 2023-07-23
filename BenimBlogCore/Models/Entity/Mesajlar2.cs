using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class Mesajlar2
    {
        [Key]
        public int Mesaj2ID { get; set; }
        public int? GönderenID { get; set; }
        public int? AlanID { get; set; }
        public string MesajBaslık { get; set; }
        public string MesajDetay { get; set; }
        public DateTime MesajTarihi { get; set; }
        public bool MesajStatu { get; set; }
        public Yazar GönderKullanıcı { get; set; }
        public Yazar AlanKullanıcı { get; set; }
    }
}
