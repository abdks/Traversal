using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents._AdminDashboardHeader
{
    public class _AdminDashboardHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
