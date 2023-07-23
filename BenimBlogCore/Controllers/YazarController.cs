using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BenimBlogCore.Controllers
{
    [Authorize]
    public class YazarController : Controller
	{
        private readonly UserManager<UygulamaKullanıcısı> _userManager;

		Context ctx =new Context();

		public YazarController(UserManager<UygulamaKullanıcısı> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult YazarMenuPartial()
		{
          


            return PartialView();	
		}
        public PartialViewResult YazarFooterPartial()
        {
            return PartialView();
        }

        public IActionResult YazarProfil()
        {
            var kullanıcıadı = User.Identity.Name;
            var kullanıcımail = ctx.Users.Where(x => x.UserName == kullanıcıadı).Select(y => y.Email).FirstOrDefault();
            var id = ctx.Yazars.Where(x => x.YazarMail == kullanıcımail).Select(y => y.YazarID).FirstOrDefault();
            var deger = ctx.Yazars.Where(x => x.YazarID == id).ToList();
            return View(deger);

        }

        [HttpGet]
		public async Task<IActionResult> YazarGüncelle()
		{   	
            YazarGuncelleViewModel model = new YazarGuncelleViewModel();
            var deger = await _userManager.FindByNameAsync(User.Identity.Name);
            if (deger!=null)
            {
                model.adısoyadı = deger.AdıSoyadı;
                model.kullanıcıadı = deger.UserName;
                model.mail = deger.Email;
                model.resimurl = deger.ResimUrl;
                
                return View(model);
            }
            return View();
        } 

		[HttpPost]
		public async Task<IActionResult> YazarGüncelle(YazarGuncelleViewModel model)
		{
           var deger1=await _userManager.FindByNameAsync(User.Identity.Name);
            if (model!=null)
            {
                deger1.UserName = model.kullanıcıadı;
                deger1.Email = model.mail;
                deger1.AdıSoyadı = model.adısoyadı;
                //deger1.ResimUrl = model.resimurl;
                deger1.PasswordHash = _userManager.PasswordHasher.HashPassword(deger1, model.sifre);
                var sonuc = await _userManager.UpdateAsync(deger1);
                return RedirectToAction("Index", "Dashboard");
            }

            return View(deger1);
           
		}


		[HttpGet]
		public IActionResult YazarEkle()
		{
			return View();
		}
		[HttpPost]
            public IActionResult YazarEkle(ProfilResmiEkle profilResmiEkle)
            {
              
                
                    Yazar yzr = new Yazar();
                    if (profilResmiEkle.YazarResim != null)
                    {
                        var uzantı = Path.GetExtension(profilResmiEkle.YazarResim.FileName);
                        var resimismi = Guid.NewGuid() + uzantı;
                        var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/YazarResimDosyası/{resimismi}");
                        var dosya = new FileStream(konum, FileMode.Create);
                        profilResmiEkle.YazarResim.CopyTo(dosya);
                        yzr.YazarResim = resimismi;

                    }
                    yzr.YazarStatu = true;
                    yzr.YazarAdı = profilResmiEkle.YazarAdı;
                    yzr.YazarHakkında = profilResmiEkle.YazarHakkında;
                    yzr.YazarMail = profilResmiEkle.YazarMail;
                    yzr.YazarSifre = profilResmiEkle.YazarSifre;
                    ctx.Yazars.Add(yzr);
                    ctx.SaveChanges();
                    return RedirectToAction("Index", "Dashboard");
                
               
            }
           
    }

}

