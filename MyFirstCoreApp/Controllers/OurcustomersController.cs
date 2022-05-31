using Microsoft.AspNetCore.Mvc;

namespace MyFirstCoreApp.Controllers
{
    public class OurcustomersController:Controller
    {
        public ActionResult CustomerPage()
        {
            return new ViewResult { ViewName = "Customers" };
        }
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult CustomerList(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return Content(id.ToString());
            return View();
        }
    }
}
