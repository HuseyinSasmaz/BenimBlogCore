using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YorumController : Controller
    {
        Context ctx=new Context();  
        public IActionResult Index()
        {
            var deger = ctx.Yorums.Include(x => x.Blog).ToList();
            return View(deger);
        }
    }
}
