using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.UI.CW21_Library_MVC.Areas.Librarian.Controllers
{
    [Area("Librarian")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
