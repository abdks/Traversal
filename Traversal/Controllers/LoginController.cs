using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Models;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

		public LoginController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
        public IActionResult SıgnUp()
        {
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> SıgnUp(UserRegisterViewModel p)
		{
			if (p.Password != p.ConfirmPassword)
			{
				ModelState.AddModelError("", "Şifreler uyuşmuyor.");
				return View(p);
			}

			AppUser appUser = new AppUser()
			{
				Name = p.Name,
				Surname = p.Surname,
				Email = p.Mail,
				UserName = p.Username
			};

			var result = await _userManager.CreateAsync(appUser, p.Password);

			if (result.Succeeded)
			{
				return RedirectToAction("SignIn");
			}
			else
			{
				foreach (var hata in result.Errors)
				{
					ModelState.AddModelError("", hata.Description);
				}
			}

			return View(p);
		}


		[HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
