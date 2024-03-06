using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Pages
{
    public class CreateNewsModel : PageModel
    {
        [BindProperty]
        public News CreatingNews { get; set; }
        public IFormFile ImageFile { get; set; }
        public List<Category> Categories { get; set; }

        public void OnGet()
        {
            var categoryServices = new CategoryServices();
            Categories = categoryServices.GetCategories();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var newsWriterCRUD = new NewsWriterCRUD();

            if (ImageFile != null && ImageFile.Length > 0)
            {
                CreatingNews.ImgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", ImageFile.FileName);
                CreatingNews.ViewImgPath = Path.Combine("~/uploads", ImageFile.FileName);


                using (var stream = new FileStream(CreatingNews.ImgPath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(stream);
                }

                CreatingNews.NewsWriterId = OnlineStuff.OnlineNewsWriter.Id;
                CreatingNews.AdminId = OnlineStuff.OnlineAdmin.Id;
                newsWriterCRUD.CreateNews(CreatingNews);
                return RedirectToPage("Index");
            }

            return RedirectToPage("Index");
        }
    }
}
