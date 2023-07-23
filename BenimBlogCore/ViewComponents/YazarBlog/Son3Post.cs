using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.ViewComponents.YazarBlog
{
	public class Son3Post:ViewComponent
	{
		Context context =new Context();	
		public IViewComponentResult Invoke()
		{
			var deger = context.Blogs.Take(3).ToList();
			return View(deger);	
		}
	}
}
