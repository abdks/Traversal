using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
