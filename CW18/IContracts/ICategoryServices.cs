using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    internal interface ICategoryServices
    {
        List<Category> GetCategories();
        void CreateCategory(string categoryName);
        void DeleteCategory(int categoryId);
        void UpdateCategory(Category updatedCategory);
    }
}
