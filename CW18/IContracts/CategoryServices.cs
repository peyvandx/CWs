using AppDbContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class CategoryServices : ICategoryServices
    {
        public void CreateCategory(string categoryName)
        {
            var db = new DefaultDbContext();
            var newCategory = new Category();
            newCategory.Name = categoryName;
            db.Categories.Add(newCategory);
            db.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var db = new DefaultDbContext();
            var deletedCategory = db.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (deletedCategory != null)
            {
                db.Categories.Remove(deletedCategory);
                db.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            var db = new DefaultDbContext();
            return db.Categories.ToList();
        }

        public void UpdateCategory(Category updatedCategory)
        {
            var db = new DefaultDbContext();
            var updatingCategory = db.Categories.FirstOrDefault(c => c.Id == updatedCategory.Id);
            updatingCategory.Name = updatedCategory.Name;
            db.SaveChanges();
        }
    }
}
