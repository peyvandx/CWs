using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Category? SelectedCategory { get; set; }
        [BindProperty]
        public News? SelectedNews { get; set; }
        public List<Category> Categories { get; set; }
        public List<News> NewsList { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var categoryServices = new CategoryServices();
            var newsServices = new NewsServices();
            var adminServices = new AdminServices();
            adminServices.AutoLoginAdminByEmail("peyvand@email.com");
            Categories = categoryServices.GetCategories();

            if (OnlineStuff.SelectedCategory != null)
            {
                SelectedCategory = OnlineStuff.SelectedCategory;
            }
            if (OnlineStuff.NewsListInTheSelectedCategory != null)
            {
                NewsList = OnlineStuff.NewsListInTheSelectedCategory;
            }
            else
            {
                NewsList = newsServices.GetAllNews();
            }
        }

        public IActionResult OnPost()
        {
            var newsServices = new NewsServices();
            //if (SelectedCategory.Id == 0) SelectedCategory = null; // yani karbar buttone edame khabar ro zade

            if (SelectedCategory != null)
            {
                if(SelectedCategory.Id == 0) // yani karbar buttone edame khabar ro zade
                {
                    // do nothing
                }
                else if (SelectedCategory.Id == -1) // yani karbar hameye akhbar ro entekhab karde
                {
                    OnlineStuff.NewsListInTheSelectedCategory = newsServices.GetAllNews();
                }
                else
                {
                    OnlineStuff.NewsListInTheSelectedCategory = newsServices.GetNewsByCategory(SelectedCategory);
                    OnlineStuff.SelectedCategory = SelectedCategory;
                }
            }
            if (SelectedNews != null)
            {
                newsServices.IncreaseNewsViews(SelectedNews.Id);
            }
            return RedirectToPage();
        }
    }
}
