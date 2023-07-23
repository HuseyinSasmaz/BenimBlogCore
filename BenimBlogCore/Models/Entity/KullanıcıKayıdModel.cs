
using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{ 
        public class KullanıcıKayıdModel
        {
            [Display(Name = "Ad Soyad")]
            [Required(ErrorMessage = "Lütfen ad soyad giriniz!")]
            public string? AdıSoyadı { get; set; }

            [Display(Name = "Şifre")]
            [Required(ErrorMessage = "Lütfen şifre giriniz!")]
            public string? Sifre { get; set; }

            [Display(Name = "Şifre tekrarı")]
            [Compare("Sifre", ErrorMessage = "Şifreler uyuşmuyor")]
            public string? SifreTekrarı { get; set; }

            [Display(Name = "Email")]
            [Required(ErrorMessage = "Lütfen email giriniz!")]
            public string? Mail { get; set; }

            [Display(Name = "Kullanıcı adı")]
            [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
            public string? KullanıcıAdı { get; set; }
        }
    
}
