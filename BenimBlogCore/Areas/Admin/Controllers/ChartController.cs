using BenimBlogCore.Models.Context;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        Context ctx = new Context();

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult KategoriChart()
        {
            //var kategoriİleBloglar = ctx.Kategoris.Where(b => b.Blogs.Any()).ToList();

            //var blogsayısı = ctx.Blogs.AsEnumerable().GroupBy(k => k.KategoriID).ToDictionary(x => x.Key, x => x.Count());

            //var chardata = kategoriİleBloglar.Select(x => x.KategoriAdı).ToArray();
            //var chartvalue = kategoriİleBloglar.Select(x => blogsayısı.ContainsKey(x.KategoriID)).ToArray();
            //ViewBag.Kategori1 = chardata;
            //ViewBag.BlogSayısı1 = chartvalue;



            var kategoriler = ctx.Kategoris.Include(b => b.Blogs).ToList();
            var kategoriAdı = kategoriler.Select(k => k.KategoriAdı).ToArray();
            var blogSayısı = kategoriler.Select(c => c.Blogs.Count).ToArray();

            ViewBag.Kategori = kategoriAdı;
            ViewBag.BlogSayısı = blogSayısı;

            return View();
            
        }
    }
}
