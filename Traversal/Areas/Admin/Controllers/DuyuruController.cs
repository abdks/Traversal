using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class DuyuruController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAnnouncementService _announcementService;

        public DuyuruController(IMapper mapper, IAnnouncementService announcementService)
        {
            _mapper = mapper;
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.GetAll());
            return View(values);
        }
    }
}
