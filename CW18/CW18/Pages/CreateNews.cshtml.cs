using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Pages
{
    public class CreateNewsModel : PageModel
    {
        [BindProperty]
        public News CreatingNews { get; set; }

        public void OnGet()
        {
        }
    }
}
