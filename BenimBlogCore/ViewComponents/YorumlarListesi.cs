using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.ViewComponents
{
	public class YorumlarListesi:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
