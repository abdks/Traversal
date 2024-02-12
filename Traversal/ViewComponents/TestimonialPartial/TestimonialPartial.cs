using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Traversal.ViewComponents.TestimonialPartial
{
    public class TestimonialPartial : ViewComponent
    {
        TestimonialManager TestimonialManager = new TestimonialManager(new EFTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = TestimonialManager.GetAll();
            return View(values);
        }
    }
}
