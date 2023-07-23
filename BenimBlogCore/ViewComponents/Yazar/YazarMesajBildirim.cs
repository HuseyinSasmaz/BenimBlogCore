using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.ViewComponents.Yazar
{
    public class YazarMesajBildirim:ViewComponent
    {
        Context ctx=new Context();  
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var usermail=ctx.Users.Where(x=>x.UserName==username).Select(y=>y.Email).FirstOrDefault();
            var id = ctx.Yazars.Where(x=>x.YazarMail==usermail).Select(y=>y.YazarID).FirstOrDefault();  
            //var deger=ctx.Mesajlar2s.Where(x=>x.MesajStatu==true).OrderByDescending(x=>x.Mesaj2ID).ToList();
            var deger = ctx.Mesajlar2s.Include(x => x.GönderKullanıcı).Where(x => x.AlanID == id).ToList();
            return View(deger);
        }
    }
}
