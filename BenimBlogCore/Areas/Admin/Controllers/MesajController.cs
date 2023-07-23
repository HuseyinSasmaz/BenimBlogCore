using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace BenimBlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MesajController : Controller
    {
        Context ctx = new Context();  
        public IActionResult GelenKutusu()
        {
            var username = User.Identity.Name;
            var usermail = ctx.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var id = ctx.Yazars.Where(x => x.YazarMail == usermail).Select(y => y.YazarID).FirstOrDefault();
            var deger = ctx.Mesajlar2s.Include(x => x.GönderKullanıcı).Where(x => x.AlanID == id).ToList();
            return View(deger);
        }
        public IActionResult GidenKutusu()
        {
            var username = User.Identity.Name;
            var usermail = ctx.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userid = ctx.Yazars.Where(x => x.YazarMail == usermail).Select(y => y.YazarID).FirstOrDefault();
            var deger = ctx.Mesajlar2s.Include(x => x.AlanKullanıcı).Where(y => y.GönderenID == userid).ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult MesajGonder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MesajGonder(Mesajlar2 p)
        {
            var username = User.Identity.Name;
            var usermail = ctx.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var userid = ctx.Yazars.Where(x => x.YazarMail == usermail).Select(y => y.YazarID).FirstOrDefault();
            p.GönderenID = userid;
            p.AlanID = 13;
            p.MesajStatu = true;
            p.MesajTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            ctx.Mesajlar2s.Add(p);
            ctx.SaveChanges();
            return RedirectToAction("GidenKutusu");
        }

    }
}
