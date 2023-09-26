using Microsoft.AspNetCore.Mvc;

namespace Aws_Notification_Service_App.Controllers
{
    public class ViewFile : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
