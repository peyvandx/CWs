using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.UI.CW21_Library_MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
