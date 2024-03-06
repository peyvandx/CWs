using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IContracts
{
    internal interface INewsWriterCRUD
    {
        void CreateNews(News news);
        List<News> GetNews();
        void UpdateNews(News news);
        void DeleteNews(int newsId);
    }
}
