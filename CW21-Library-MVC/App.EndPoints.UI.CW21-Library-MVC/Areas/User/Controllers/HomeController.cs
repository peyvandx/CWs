using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.UI.CW21_Library_MVC.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
