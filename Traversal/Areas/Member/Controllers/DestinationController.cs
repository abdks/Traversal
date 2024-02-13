using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
   
    public class DestinationController : Controller
    {
        DestinationManager Manager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = Manager.GetAll();
            return View(values);
        }
    }
}
