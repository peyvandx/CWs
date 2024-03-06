using AppDbContext;
using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Pages
{
    public class CategoriesManagementModel : PageModel
    {
        [BindProperty]
        public Category SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }
        public void OnGet()
        {
            var categoryServices = new CategoryServices();
            Categories = categoryServices.GetCategories();
        }

        public IActionResult OnPost(string categoryName) 
        {
            var categoryServices = new CategoryServices();
            if (categoryName != null)
            {
                categoryServices.CreateCategory(categoryName);
            }
            if (SelectedCategory.Id != null && SelectedCategory.Name == null)
            {
                categoryServices.DeleteCategory(SelectedCategory.Id);
            }
            if (SelectedCategory.Id != null && SelectedCategory.Name != null)
            {
                categoryServices.UpdateCategory(SelectedCategory);
            }

            return RedirectToPage();
        }
    }
}
