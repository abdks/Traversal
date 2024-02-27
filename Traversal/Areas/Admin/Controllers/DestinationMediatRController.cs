using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    public class DestinationMediatRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
