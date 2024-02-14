using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents._DashboardBanner
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
