using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Controllers
{
	[AllowAnonymous]
	public class HaberBulteniController : Controller
	{
		Context ctx=new Context();

		[HttpGet]
		public PartialViewResult AboneOl()
		{
			return PartialView();
		}
		[HttpPost]
        public PartialViewResult AboneOl(HaberBulteni haber)
		{
			
                haber.MailStatu = true;
                ctx.HaberBultenis.Add(haber);
                ctx.SaveChanges();
			return PartialView();
          
		
        }
		
    }
}
