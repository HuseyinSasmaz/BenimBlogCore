using BenimBlogCore.Models.Entity;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BenimBlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<UygulamaRolu> _roleManager;
        private readonly UserManager<UygulamaKullanıcısı> _userManager;

        public RoleController(RoleManager<UygulamaRolu> roleManager, UserManager<UygulamaKullanıcısı> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var deger = _roleManager.Roles.ToList();
            return View(deger);
        }

        public IActionResult RolEkle() 
        {
            return View();
        }
        [HttpPost]  
        public async Task<IActionResult> RolEkle(RolViewModel rolViewModel)
        {
            if(ModelState.IsValid)
            {
                var rol = new UygulamaRolu()
                {
                    Name = rolViewModel.RolAdı
                };

                var deger=await _roleManager.CreateAsync(rol);
                if (deger.Succeeded)
                {
                    return RedirectToAction("Index");   
                }
                else
                {
                    foreach (var item in deger.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }   
            return View(rolViewModel);
        }
        [HttpGet]
        public IActionResult RolGüncelle(int id)
        {
            var deger = _roleManager.Roles.Where(x => x.Id==id).FirstOrDefault();
           
                RolGüncelleViewModel model = new RolGüncelleViewModel
                {
                    id = deger.Id,
                    roladı = deger.Name
                };
                return View(model);
            
           
        }
        [HttpPost]      
        public async Task<IActionResult> RolGüncelle(RolGüncelleViewModel model)
        {
            var deger = _roleManager.Roles.FirstOrDefault(x => x.Id == model.id);
            deger.Name = model.roladı;
           var sonuc =await _roleManager.UpdateAsync(deger);
            if (sonuc.Succeeded)
            {
                return RedirectToAction("Index");

            }
            return View(model);

        }
        public async Task<IActionResult> RolSil(int id)
        {
            var deger = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var sonuc=await _roleManager.DeleteAsync(deger);
            if (sonuc.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult KullanıcıRolListe()
        {
            var deger = _userManager.Users.ToList();
            return View(deger);
        }

        public async Task<IActionResult> RolAta(int id)
        {
            var user=_userManager.Users.FirstOrDefault(x=>x.Id==id);
            var rol = _roleManager.Roles.ToList();
            var userRole=await _userManager.GetRolesAsync(user);
            TempData["userId"] = user.Id;

            List<RolAtaViewModel> model = new List<RolAtaViewModel>();
            foreach (var item in rol)
            {
                RolAtaViewModel p = new RolAtaViewModel();
                p.RolId = item.Id;
                p.Rolü = item.Name;
                p.Rolüvarmi = userRole.Contains(item.Name);
                model.Add(p);
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RolAta(List<RolAtaViewModel> model)
        {
            var userID = (int)TempData["userId"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userID);
            foreach (var item in model)
            {
                if (item.Rolüvarmi)
                {
                    await _userManager.AddToRoleAsync(user, item.Rolü);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Rolü);
                }
            }
            return RedirectToAction("KullanıcıRolListe");
        }
    }
}
