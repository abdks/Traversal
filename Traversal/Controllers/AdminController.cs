using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialAppBrand()
        {
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
