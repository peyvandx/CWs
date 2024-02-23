using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    internal interface INewsServices
    {
        List<News> GetAllNews();
        List<News> GetNewsByCategory(Category category);
    }
}
