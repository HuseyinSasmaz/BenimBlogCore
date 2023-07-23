using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.ViewComponents.Yazar
{
    public class YazarDuyuruBildirimleri:ViewComponent
    {
        Context ctx = new Context();
        public IViewComponentResult Invoke()
        {
            var deger = ctx.Bildirimlers.Where(x=>x.BildirimStatu==true).OrderByDescending(x=>x.BildirimID).ToList();
            return View(deger);
        }
    }
}
