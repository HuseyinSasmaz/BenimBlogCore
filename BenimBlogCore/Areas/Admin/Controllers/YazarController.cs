using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YazarController : Controller
    {
        Context ctx = new Context();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YazarListesi()
        {
            var deger = ctx.Yazars.ToList();

            return View(deger);  
        }
    }
}
