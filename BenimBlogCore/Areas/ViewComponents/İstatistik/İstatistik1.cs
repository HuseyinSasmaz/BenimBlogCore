using BenimBlogCore.Models.Context;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.CodeAnalysis.VisualBasic;
using System.Xml.Linq;

namespace BenimBlogCore.Areas.ViewComponents.İstatistik
{
    public class İstatistik1:ViewComponent
    {
        Context ctx=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.blg = ctx.Blogs.Count();
            ViewBag.msg=ctx.Mesajlars.Count();
            ViewBag.msj = ctx.Yorums.Count();

            string api = "e26cbfacea8c861e36d9d589b170f5d8";
            string baglantı = "https://api.openweathermap.org/data/2.5/weather?q=Adana&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument dokuman = XDocument.Load(baglantı);
            ViewBag.api1=dokuman.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();  
        }
    }
}
