using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
       
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _announcementService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement(string x)
        {
            // Gerekirse işlemler yapılabilir, ancak şu an için sadece bir view'a yönlendirme örneği:
            return View();
        }


    }
}
