using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Areas.ViewComponents.İstatistik
{
    public class İstatistik2:ViewComponent
    {
        Context ctx=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.sonblg=ctx.Blogs.OrderByDescending(x=>x.BlogID).Select(x=>x.BlogBaslık).FirstOrDefault();    
            return View();  
        }
    }
}
