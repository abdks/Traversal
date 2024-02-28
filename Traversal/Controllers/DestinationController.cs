using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager DestinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = DestinationManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Id = id;
            var values = DestinationManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Details(Destination p)
        {
            return View();
        }
    }
}
