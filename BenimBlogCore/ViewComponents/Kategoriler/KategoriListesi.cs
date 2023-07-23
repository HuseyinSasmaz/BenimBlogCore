using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.ViewComponents.Kategoriler
{
	public class KategoriListesi:ViewComponent
	{
		Context ctx = new Context();
		public IViewComponentResult Invoke()
		{
			
			var deger = ctx.Kategoris.ToList();
			return View(deger);	
		}
	}
}
