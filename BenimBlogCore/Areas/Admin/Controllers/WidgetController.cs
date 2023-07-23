using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidgetController : Controller
    {
         
        public IActionResult Index()
        {

            return View();
        }
    }
}
