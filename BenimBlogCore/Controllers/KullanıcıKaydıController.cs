using BenimBlogCore.Models.Entity;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Controllers
{
    [AllowAnonymous]
    public class KullanıcıKaydıController : Controller
    {
       private readonly UserManager<UygulamaKullanıcısı> _userManager;

		public KullanıcıKaydıController(UserManager<UygulamaKullanıcısı> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Kayıt()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Kayıt(KullanıcıKayıdModel model)
		{
			if (ModelState.IsValid)
			{
				var kullanıcı = new UygulamaKullanıcısı
				{
					UserName = model.KullanıcıAdı,
					AdıSoyadı = model.AdıSoyadı,
					Email = model.Mail
				};
				var sonuc = await _userManager.CreateAsync(kullanıcı, model.Sifre);

				if (sonuc.Succeeded)
				{
					return RedirectToAction("Index", "Giris");
				}
				else
				{
					foreach (var hata in sonuc.Errors)
					{
						ModelState.AddModelError("", "Bilgiler hatalı yada eksik...");
					}
				}
				
			}


			return View(model);
		}
	}
}
