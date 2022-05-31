using Microsoft.AspNetCore.Mvc;

namespace MyFirstCoreApp.Controllers
{
    public class ContactController:Controller
    {
        public ActionResult SupportPage()
        {
            return Json("Support us");
        }
        public ViewResult AdminPanel()
        {
            return new ViewResult { ViewName = "Login" }; 
        }
    }
}
