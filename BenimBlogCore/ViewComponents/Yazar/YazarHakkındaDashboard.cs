using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.ViewComponents.Yazar
{
    public class YazarHakkındaDashboard:ViewComponent
    {
    
        Context ctx =new Context();

        public IViewComponentResult Invoke()
        {
            var kullanıcıadı = User.Identity.Name;
            var kullanıcımail = ctx.Users.Where(x => x.UserName == kullanıcıadı).Select(y => y.Email).FirstOrDefault();
            var id = ctx.Yazars.Where(x => x.YazarMail == kullanıcımail).Select(y => y.YazarID).FirstOrDefault();
            var deger = ctx.Yazars.Where(x=>x.YazarID==id).ToList();
            return View(deger);
            
        }
    }
}
