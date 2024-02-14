using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.PlatformPartial
{
    public class PlatformPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
