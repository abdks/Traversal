using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            var values = commentManager.TGetListCommentWithDestination();
            return View(values);
        }
    }
}
