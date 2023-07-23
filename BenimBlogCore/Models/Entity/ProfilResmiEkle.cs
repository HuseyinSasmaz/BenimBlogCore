namespace BenimBlogCore.Models.Entity
{
    public class ProfilResmiEkle
    {
        public int YazarID { get; set; }
        public string YazarAdı { get; set; }
        public string YazarHakkında { get; set; }
        public IFormFile YazarResim { get; set; }
        public string YazarMail { get; set; }
        public string YazarSifre { get; set; }
        public bool YazarStatu { get; set; }
    }
}
