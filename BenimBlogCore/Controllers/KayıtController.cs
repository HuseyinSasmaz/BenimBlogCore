using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Controllers
{
	[AllowAnonymous]
	public class KayıtController : Controller
	{
		Context ctx=new Context();
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Yazar yzr)
		{
			yzr.YazarStatu = true;
			yzr.YazarHakkında = "DenemeDenemeDeneme";
			ctx.Yazars.Add(yzr);
			ctx.SaveChanges();
			return RedirectToAction("Index","Blog");
		}
	}
}
