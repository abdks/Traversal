using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents._TotalRevenue
{
    public class _TotalRevenue:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }  
    }
}
