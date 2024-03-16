using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.UI.CW21_Library_MVC.Controllers
{
    public class LibrarianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
