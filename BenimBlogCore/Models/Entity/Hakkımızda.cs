using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class Hakkımızda
    {
        [Key]
        public int HakkımızdaID { get; set; }
        public string? HakkımızdaDetaylar1 { get; set; }
        public string? HakkımızdaDetaylar2 { get; set; }
        public string? HakkımızdaResim1 { get; set; }
        public string? HakkımızdaResim2 { get; set; }
        public string? HakkımızdaLokasyon { get; set; }
        public bool HakkımızdaStatu { get; set; }
    }
}
