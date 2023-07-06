using NewsAppExample.Interface;
using NewsAppExample.Models;

namespace NewsAppExample.Services
{
    public class MockNewsArticleService : INewsArticleService
    {
        public List<NewsArticle> GetNewsArticles()
        {
            // this is test data test data!!!!

            List<NewsArticle> articles = new List<NewsArticle>();

            articles.Add(new NewsArticle() { Id = 1, Title = "Test prva vijest", Subtitle = "Test Prva vijest subtitle" });
            articles.Add(new NewsArticle() { Id = 2, Title = "Test Druga vijest", Subtitle = "Test Druga vijest subtitle" });
            articles.Add(new NewsArticle() { Id = 3, Title = "Test Treca vijest", Subtitle = "Test Treca vijest subtitle" });
            
            // this is test data test data!!!!

            return articles;
        }
    }
}
