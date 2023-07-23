using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class KullanıcıGirisModel
    {
        
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!")]
        public string? kullanıcıadı { get; set; }

       
        [Required(ErrorMessage = "Lütfen şifre giriniz!")]
        public string? sifre { get; set; }
    }
}
