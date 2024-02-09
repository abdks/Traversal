using BusinessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.PopularDestinations
{
    public class PopularDestinationPartial : ViewComponent
    {
        DestinationManager DestinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = DestinationManager.GetAll();
            return View(values);  
        }
    }
}
