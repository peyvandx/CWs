using AppDbContext;
using Entities;
using IContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class NewsWriterCRUD : INewsWriterCRUD
    {
        public void CreateNews(News news)
        {
            var db = new DefaultDbContext();
            db.News.Add(news);
            db.SaveChanges();
        }

        public void DeleteNews(int newsId)
        {
            var db = new DefaultDbContext();
            var deletedNews = db.News.FirstOrDefault(n => n.Id == newsId);
            if(deletedNews != null)
            {
                db.News.Remove(deletedNews);
                db.SaveChanges();
            }
        }

        public List<News> GetNews()
        {
            return OnlineStuff.OnlineNewsWriter.NewsList;
        }

        public void UpdateNewst(News news)
        {
            var db = new DefaultDbContext();
            var updatingNews = db.News.FirstOrDefault(n => n.Id == news.Id);
            updatingNews.ImgPath = news.ImgPath;
            updatingNews.Heading = news.Heading;
            updatingNews.Description = news.Description;
            db.SaveChanges();
        }
    }
}
