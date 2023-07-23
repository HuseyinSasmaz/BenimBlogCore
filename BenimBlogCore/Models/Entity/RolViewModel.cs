using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    
    public class RolViewModel
    {
        
        [Required(ErrorMessage ="Rol Adı Giriniz")]
        public string? RolAdı { get; set; }
    }
}
