using App.Domain.Core.Advertise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Advertise.Contracts.Repositories
{
    public interface ICategoryRepository
    {
        void CreateCategory(Category category);
        Category GetCategoryById(int id);
        List<Category> GetAllCategories();
        void UpdateCategory(Category updatedCategory);
        void SoftDeleteCategory(int id);
        void HardDeleteCategory(int id);
    }
}
