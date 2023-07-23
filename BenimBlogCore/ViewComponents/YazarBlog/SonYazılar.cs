using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.ViewComponents.YazarDigerYazılar
{
	public class SonYazılar:ViewComponent
	{
		Context ctx=new Context();	
		public IViewComponentResult Invoke()
		{
				
		var deger=ctx.Blogs.Where(x => x.YazarID == 2).ToList();
			return View(deger);	
		}
	}
}
