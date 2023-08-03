using NewsAppExample.Interface;
using NewsAppExample.Models;

namespace NewsAppExample.Services
{
    public class NewsArticleService : INewsArticleService
    {
        public NewsArticleService()
        {
            
        }

        public List<NewsArticle> GetNewsArticles()
        {
            // Imagine this is a real data from server

            List<NewsArticle> articles = new List<NewsArticle>();

            articles.Add(new NewsArticle() { Id = 1, Title = "Prva vijest", Subtitle = "Prva vijest subtitle" });
            articles.Add(new NewsArticle() { Id = 2, Title = "Druga vijest", Subtitle = "Druga vijest subtitle" });
            articles.Add(new NewsArticle() { Id = 3, Title = "Treca vijest", Subtitle = "Treca vijest subtitle" });

            // Imagine this is a real data from server

            return articles;
        }

    }
}
