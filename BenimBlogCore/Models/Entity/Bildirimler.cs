using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class Bildirimler
    {
        [Key]
        public int BildirimID { get; set; }
        public string BildirimTipi { get; set; }
        public string BildirimSembolü { get; set; }
        public string BildirimDetay { get; set; }
        public DateTime BildirimTarihi { get; set; }
        public bool BildirimStatu { get; set; }
        public string BildirimRengi { get; set; }
    }
}
