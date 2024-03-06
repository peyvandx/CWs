using AppDbContext;
using Entities;


namespace Contracts
{
    public class NewsServices : INewsServices
    {
        public List<News> GetAllNews()
        {
            var db = new DefaultDbContext();
            return db.News.ToList();
        }

        public List<News> GetNewsByCategory(Category category)
        {
            var db = new DefaultDbContext();
            return db.News.Where(n => n.CategoryId == category.Id).ToList();
        }

        public void IncreaseNewsViews(int newsId)
        {
            var db = new DefaultDbContext();
            var selectedNews = db.News.FirstOrDefault(n => n.Id == newsId);
            if (selectedNews != null)
            {
                selectedNews.Views += 1;
                db.SaveChanges();
            }
        }

        public void AddToNewsQueueToConfirmation(News news)
        {
            OnlineStuff.OnlineAdmin.NewsQueueToBeConfirmed.Add(news);
        }
    }
}
