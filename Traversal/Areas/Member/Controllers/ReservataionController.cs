using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservataionController : Controller
    {
        DestinationManager DestinationManager = new DestinationManager(new EfDestinationDal());
       ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
        public IActionResult MyOldReservation() 
        {
            return View();
        }
        public IActionResult MyCurrentReservation()
        {

            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in DestinationManager.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.Locations = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserID = 9;
            p.Status = "Onay Bekliyor";
            reservationManager.TAdd(p);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
