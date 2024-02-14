using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        //CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestination();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.GetById(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
