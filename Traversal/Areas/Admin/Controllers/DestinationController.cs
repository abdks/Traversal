using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationManager DestinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = DestinationManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            DestinationManager.TAdd(destination);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            var values = DestinationManager.GetById(id);
            DestinationManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = DestinationManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
                DestinationManager.TUpdate(destination);
            return RedirectToAction("Index");
        }

    }
}
