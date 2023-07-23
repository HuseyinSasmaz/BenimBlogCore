using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        public string YorumKullanıcıAdı { get; set; }
        public string YorumBaslık { get; set; }
        public string Yorumİcerik { get; set; }
        public DateTime YorumTarih { get; set; }
        public int BlogSkoru { get; set; }
        public bool YorumStatu { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
