using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager DestinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = DestinationManager.GetAll();
            return View(values); return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
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
