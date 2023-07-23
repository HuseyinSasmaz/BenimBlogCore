using Microsoft.AspNetCore.Identity;

namespace BenimBlogCore.Models.Entity
{
    public class UygulamaKullanıcısı:IdentityUser<int>
    {
        public string? AdıSoyadı { get; set; }
        public string? ResimUrl { get; set; }
    }
}
