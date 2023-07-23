using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NuGet.Protocol;
using System.Security.Claims;

namespace BenimBlogCore.Controllers
{
	[AllowAnonymous]
	public class GirisController : Controller
	{
		Context ctx = new Context();
		private readonly SignInManager<UygulamaKullanıcısı> _signInManager;

        public GirisController(SignInManager<UygulamaKullanıcısı> signInManager)
        {
            
            _signInManager = signInManager;
        }

        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(KullanıcıGirisModel p)
		{
			if (ModelState.IsValid)
			{
                var sonuc = await _signInManager.PasswordSignInAsync(p.kullanıcıadı, p.sifre,false,true);
				if (sonuc.Succeeded)
				{
					return RedirectToAction("Index", "Dashboard");
				}
				else
				{
					//return RedirectToAction("Index", "Giris");
					ModelState.AddModelError("", "Girilen bilgiler hatalıdır...!");
				} 
            }

			return View(); 
		}

		public async Task<IActionResult> Cıkıs()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index","Giris");
		}
		public IActionResult ErisimEngeli()
		{
			return View();
		}

    }
}
