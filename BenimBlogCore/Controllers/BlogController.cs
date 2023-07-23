using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
	{
		Context ctx = new Context();
        [AllowAnonymous]
        public IActionResult Index()
		{
			var deger = ctx.Blogs.Include(x=>x.Kategori).ToList();
			return View(deger);
		}
        [AllowAnonymous]
        public IActionResult BlogDetay(int id)
		{
			
			ViewBag.dgr = id;
		
			var deger = ctx.Blogs.Where(x => x.BlogID == id).ToList();
			return View(deger);
		}
        //[Authorize]
        public IActionResult YazarınBlogları()
		{
			var username = User.Identity.Name;
			var usermail = ctx.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
			var userid=ctx.Yazars.Where(x=>x.YazarMail==usermail).Select(y=>y.YazarID).FirstOrDefault();	
			var deger = ctx.Blogs.Include(x=>x.Kategori).Where(y => y.YazarID==userid).ToList();			
			return View(deger);
			
		}
        [Authorize]
        [HttpGet]
		public IActionResult BlogEkle()
		{
		
			List<SelectListItem> ktg = (from x in ctx.Kategoris.ToList()
										select new SelectListItem
										{
											Text=x.KategoriAdı,
											Value=x.KategoriID.ToString()
										}
										).ToList();
            //List<SelectListItem> yzr = (from x in ctx.Yazars.ToList()
            //                            select new SelectListItem
            //                            {
            //                                Text = x.YazarAdı,
            //                                Value = x.YazarID.ToString()
            //                            }
            //                            ).ToList();
            ViewBag.ktg = ktg;	
            //ViewBag.yzr = yzr;	
			return View();
		}
        [Authorize]
        [HttpPost]
		public IActionResult BlogEkle(Blog p)
		{
            var username = User.Identity.Name;
			var usermail= ctx.Users.Where(x=>x.UserName==username).Select(y => y.Email).FirstOrDefault();
            var userid = ctx.Yazars.Where(x => x.YazarMail == usermail).Select(y => y.YazarID).FirstOrDefault();

            p.BlogStatu = true;
				p.BlogTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
			    p.YazarID = userid;
                ctx.Blogs.Add(p);
                ctx.SaveChanges();
			     return RedirectToAction("YazarınBlogları","Blog");
          
		}
        [Authorize]
        public IActionResult BlogSil(int id)
		{
			var deger = ctx.Blogs.Find(id);
			ctx.Blogs.Remove(deger);
			ctx.SaveChanges();
			return RedirectToAction("YazarınBlogları");	
		}
        [Authorize]
        [HttpGet]
		public IActionResult BlogGüncelle(int id)
		{
	
            List<SelectListItem> ktg = (from x in ctx.Kategoris.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.KategoriAdı,
                                            Value = x.KategoriID.ToString()
                                        }
                                        ).ToList();
			List<SelectListItem> yzr = (from x in ctx.Yazars.ToList()
										select new SelectListItem
										{
											Text = x.YazarAdı,
											Value = x.YazarID.ToString()
										}
									   ).ToList();
	       
            ViewBag.ktg = ktg;
            ViewBag.yzr = yzr;
			var deger = ctx.Blogs.Find(id);
                return View(deger);
          
		}
        [Authorize]
        [HttpPost]
        public IActionResult BlogGüncelle(Blog blog)
        {
            var username = User.Identity.Name;
			var usermail=ctx.Users.Where(x=>x.UserName== username).Select(y=>y.Email).FirstOrDefault();	
            var id = ctx.Yazars.Where(x => x.YazarMail == usermail).Select(y => y.YazarID).FirstOrDefault();
            blog.YazarID=id;;
			ctx.Blogs.Update(blog);	
			ctx.SaveChanges();
            return RedirectToAction("YazarınBlogları","Blog");
        }
    }
}
