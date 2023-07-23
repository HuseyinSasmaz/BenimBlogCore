using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }
        public string? YazarAdı { get; set; }
        public string? YazarHakkında { get; set; }
        public string? YazarResim { get; set; }
        public string? YazarMail { get; set; }
        public string? YazarSifre { get; set; }
        public bool YazarStatu { get; set; }
        public List<Blog> Blogs { get; set; }  
        public virtual ICollection<Mesajlar2> YazarGönderen { get;}
        public virtual ICollection<Mesajlar2> YazarAlıcı { get;}
    }
}
