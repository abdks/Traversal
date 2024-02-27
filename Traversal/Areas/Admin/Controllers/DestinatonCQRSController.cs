using Microsoft.AspNetCore.Mvc;
using Traversal.CQRS.Handlers.DestinationHandlers;
using Traversal.CQRS.Queries.DestinatonQueries;
using TraversalCoreProje.CQRS.Handlers.DestinationHandler;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
   // [Route("Admin/DestinatonCQRS")]

    public class DestinatonCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _handler;
        private readonly GetDestinationByIDQueryHandler _getDestinationBy;

        public DestinatonCQRSController(GetDestinationByIDQueryHandler getDestinationBy, GetAllDestinationQueryHandler handler)
        {
            _getDestinationBy = getDestinationBy;
            _handler = handler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationBy.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }
    }
}
