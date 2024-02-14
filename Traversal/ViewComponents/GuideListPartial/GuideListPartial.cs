using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatatAccessLayer.EntityFreamework;

namespace Traversal.ViewComponents.GuideListPartial
{
    public class GuideListPartial : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManager.GetAll();
            return View(values);
        }
    }
}
