using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Controllers
{
	[AllowAnonymous]
	public class İletişimController : Controller
	{
		Context ctx=new Context();
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(İletisim iletisim)
		{
			iletisim.İletisimTarih=DateTime.Parse(DateTime.Now.ToShortDateString());
			iletisim.İletisimStatu = true;
			ctx.Add(iletisim);
			ctx.SaveChanges();

			return RedirectToAction("Index","Blog");
		}
	}
}
