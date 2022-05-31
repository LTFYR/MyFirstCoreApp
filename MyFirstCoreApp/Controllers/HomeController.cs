using Microsoft.AspNetCore.Mvc;

namespace MyFirstCoreApp.Controllers
{
    public class HomeController:Controller
    {
        public ContentResult CustomPage()
        {
            return Content("This is Content result example");
        }
        public JsonResult JsonPage()
        {
            return Json("This is JSON result example"); 
        }
        public ViewResult ViewPage()
        {
            ViewResult newview = new ViewResult();
            newview.ViewName = "ViewPage";
            return newview;
        }
        public ViewResult ContactUs()
        {
            return new ViewResult { ViewName = "ContactUs" };
        }
        public ActionResult HomePage()
        {
            return Json("Home Page");
        }
    }
}
