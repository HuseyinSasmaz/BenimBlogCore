
using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class Admin
    {
        [Key]

        public int AdminID { get; set; }

        public string? KullanıcıAdı { get; set; }

        public string? Şifre { get; set; }

        public string? Adı { get; set; }

        public string? Acıklama { get; set; }

        public string? ResimYolu { get; set; }

        public string? Rolu { get; set; }
    }
}
