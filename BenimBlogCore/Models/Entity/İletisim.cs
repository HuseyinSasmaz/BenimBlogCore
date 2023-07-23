using System.ComponentModel.DataAnnotations;

namespace BenimBlogCore.Models.Entity
{
    public class İletisim
    {
        [Key]
        public int İletisimID { get; set; }
        public string İletisimKullanıcıAdı { get; set; }
        public string İletisimMail { get; set; }
        public string İletisimBaslık { get; set; }
        public string İletisimMesaj { get; set; }
        public DateTime İletisimTarih { get; set; }
        public bool İletisimStatu { get; set; }
    }
}
