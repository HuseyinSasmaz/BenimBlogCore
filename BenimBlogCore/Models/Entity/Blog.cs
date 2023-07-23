using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogBaslık { get; set; }
        public string Blogİcerik { get; set; }
        public string BlogKucukResim { get; set; }
        public string BlogResim { get; set; }
        public DateTime BlogTarih { get; set; }
        public bool BlogStatu { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
		public int YazarID { get; set; }
		public Yazar Yazar { get; set; }
		public List<Yorum> Yorums { get; set; }
    }
}
