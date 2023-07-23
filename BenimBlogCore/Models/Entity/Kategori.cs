using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdı { get; set; }
        public string KategoriAcıklama { get; set; }
        public bool KategoriStatu { get; set; }
        public  List<Blog> Blogs { get; set; }
    }
}
