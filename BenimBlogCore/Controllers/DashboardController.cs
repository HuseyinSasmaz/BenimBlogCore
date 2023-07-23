using BenimBlogCore.Models.Context;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        Context ctx = new Context();
        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var usermail = ctx.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var yazarid=ctx.Yazars.Where(x => x.YazarMail==usermail).Select(y=>y.YazarID).FirstOrDefault(); 
            ViewBag.blg = ctx.Blogs.Count();
            ViewBag.ktg = ctx.Kategoris.Count();
            ViewBag.yzr = ctx.Blogs.Where(x => x.YazarID == yazarid).Count();
            return View();
        }
    }
}
