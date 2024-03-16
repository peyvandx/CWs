using App.Domain.Core.Advertise.Contracts.Repositories;
using App.Domain.Core.Advertise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repo.EF.Sql.Advertise
{
    internal class CategoryRepository : ICategoryRepository
    {
        public void CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public void HardDeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category updatedCategory)
        {
            throw new NotImplementedException();
        }
    }
}
