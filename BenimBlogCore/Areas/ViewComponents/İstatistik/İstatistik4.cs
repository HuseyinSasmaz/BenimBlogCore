using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Areas.ViewComponents.İstatistik
{
    public class İstatistik4:ViewComponent
    {
        Context ctx =new Context();     
        public IViewComponentResult Invoke()
        {
            ViewBag.dgr1 = ctx.Admins.Where(x => x.AdminID == 1).Select(y => y.Adı).FirstOrDefault();
            ViewBag.dgr2 = ctx.Admins.Where(x => x.AdminID == 1).Select(y => y.Acıklama).FirstOrDefault();
            ViewBag.dgr3 = ctx.Admins.Where(x => x.AdminID == 1).Select(y => y.ResimYolu).FirstOrDefault();

            return View();
        }
    }
}
