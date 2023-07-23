using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Controllers
{
	[AllowAnonymous]
	public class HataSayfasıController : Controller
	{
		public IActionResult Hata1(int code)
		{
			return View();
		}
	}
}
