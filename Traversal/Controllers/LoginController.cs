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
		private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
        [HttpPost]
        public async Task<IActionResult> SignIn(UserSigInViewModel p)
        {
			if(ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.Username,p.Password,false,true);
				if(result.Succeeded) 
				{
					return RedirectToAction("Index", "Profile",new {area = "Member"});
				}
				else
				{
					return RedirectToAction("SignIn", "Login");
				}
			}
            return View();
        }
    }
}
