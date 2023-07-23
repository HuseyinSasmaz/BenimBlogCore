using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;


namespace BenimBlogCore.ViewComponents.Yorumlar
{
	public class BlogİleYorumListesi:ViewComponent
	{
		Context ctx = new Context();
		public IViewComponentResult Invoke(int id)
		{
			var deger = ctx.Yorums.Where(x => x.BlogID == id);
			return View(deger);
		}
	}
}
