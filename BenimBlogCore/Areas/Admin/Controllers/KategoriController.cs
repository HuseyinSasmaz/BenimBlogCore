using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;


namespace BenimBlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KategoriController : Controller
    {
        Context ctx = new Context();
            
        public IActionResult Index(int sayfa=1)
        {
            var deger = ctx.Kategoris.ToPagedList(sayfa,2);
            return View(deger);
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(Kategori ktg)
        {
            ktg.KategoriStatu = true;
            ctx.Kategoris.Add(ktg);
          
            return RedirectToAction("Index","Kategori");       
        }
        public IActionResult KategoriSil(int id)
        {
           var deger= ctx.Kategoris.Find(id);
            ctx.Remove(deger);  
           
            return RedirectToAction("Index","Kategori");  
        }
    }
}
