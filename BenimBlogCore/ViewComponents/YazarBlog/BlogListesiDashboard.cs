using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.ViewComponents.YazarBlog
{
    public class BlogListesiDashboard:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var deger = context.Blogs.Include(x=>x.Kategori).Take(7).ToList();
            return View(deger);
        }
    }
}
