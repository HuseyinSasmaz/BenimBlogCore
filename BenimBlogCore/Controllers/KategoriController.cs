using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Controllers
{
	[AllowAnonymous]
	public class KategoriController : Controller
    {
        Context ctx = new Context();
        public IActionResult Index()
        {
               
            var deger=ctx.Kategoris.ToList();
            return View(deger);
        }
    }
}
