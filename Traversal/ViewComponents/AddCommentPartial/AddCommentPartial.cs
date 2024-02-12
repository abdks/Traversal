using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.AddComment
{
    public class AddCommentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
