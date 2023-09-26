using Aws_Notification_Service_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aws_Notification_Service_App.Controllers
{
    public class UploadFile : Controller
    {
        public IActionResult Index()
        {
            var model = new FileUploadViewModel();
            return View(model);
        }
    }
}
