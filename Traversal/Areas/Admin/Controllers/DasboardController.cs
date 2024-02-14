using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DasboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
