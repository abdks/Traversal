using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    public class DasboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DasboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " "+values.Surname;
            ViewBag.Image = values.ImageURL;
            return View();
        }
    }
}
