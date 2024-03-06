using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Pages
{
    public class NewsWritersRegisterModel : PageModel
    {
        [BindProperty]
        public NewsWriter RegisteringNewsWriter { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var authentication = new Authentication();
            authentication.Register(RegisteringNewsWriter);
            return RedirectToPage("NewsWritersLogin");
        }
    }
}
