using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.CommentPartial
{
    public class CommentPartial : ViewComponent
    {
        CommentManager _commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentManager.TGetDestinationByID(id);
            return View(values);
        }
    }
}
