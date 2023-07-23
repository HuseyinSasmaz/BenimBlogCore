
using System.IO;
using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;
using BenimBlogCore.Models.Entity;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        Context ctx=new Context();

        public IActionResult Index()
        {
            var deger = ctx.Blogs.Include(x => x.Kategori).ToList();
            return View(deger);  

        }
       
    }
}
