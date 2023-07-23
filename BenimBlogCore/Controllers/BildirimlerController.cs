using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Controllers
{
    [Authorize]
    public class BildirimlerController : Controller
    {
        Context ctx = new Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BildirimListesi() 
        {
            var deger = ctx.Bildirimlers.ToList();
            return View(deger);  
        }
    }
}
