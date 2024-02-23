using Contracts;
using DTOs;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Pages
{
    public class NewsWritersLoginModel : PageModel
    {
        [BindProperty]
        public LoginDTO LoginDto { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            var authentication = new Authentication();
            var authResult = authentication.Login(LoginDto);
            if (authResult)
            {
                return RedirectToPage("Index");
            } else
            {
                return RedirectToPage("Error");
            }
        }
    }
}
