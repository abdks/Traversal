using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using Traversal.Areas.Member.Models;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    [Route ("Member/[controller]/[action]")]
    
    public class ProfileController : Controller
    {
   
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEdİtViewModel userEdİtViewModel = new UserEdİtViewModel();
            userEdİtViewModel.name = values.Name;
            userEdİtViewModel.surname = values.Surname;
            userEdİtViewModel.phonenumber = values.PhoneNumber;
            userEdİtViewModel.mail = values.Email;
            return View(userEdİtViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEdİtViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(p.Image != null)
            {

                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/Userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageURL = imagename;

            }
            user.Name = p.name;
            user.Surname = p.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("SignIn","Login");
            }
            return View();
        }
    }
}
