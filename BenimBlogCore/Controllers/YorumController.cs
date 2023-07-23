using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.Controllers
{
	[AllowAnonymous]
	public class YorumController : Controller
	{
		Context ctx = new Context();
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult PartialYorumEkle()
		{
			return PartialView();	
		}
		[HttpPost]
        public IActionResult PartialYorumEkle(Yorum yorum)
        {
            var blog = ctx.Blogs.Include(y => y.Yorums).Where(b=>b.BlogID==yorum.BlogID).FirstOrDefault();

			
			yorum.BlogID = 22;
			yorum.BlogSkoru = 1;
			yorum.YorumStatu = true;
			yorum.YorumTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
			ctx.Yorums.Add(yorum);
			ctx.SaveChanges();
			return RedirectToAction("BlogDetay", "Blog",new{ blog.BlogID});
        }

        public PartialViewResult PartialYorumListesi(int id)
		{
			var deger=ctx.Yorums.Where(x=>x.BlogID==id);		
			return PartialView(deger);
		}
	}
}
