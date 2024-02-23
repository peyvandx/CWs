using AppDbContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class NewsServices : INewsServices
    {
        public List<News> GetAllNews()
        {
            throw new NotImplementedException();
        }

        public List<News> GetNewsByCategory(Category category)
        {
            var db = new DefaultDbContext();
            return db.News.Where(n => n.CategoryId == category.Id).ToList();
        }
    }
}
