using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.CommentPartial
{
    public class CommentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
