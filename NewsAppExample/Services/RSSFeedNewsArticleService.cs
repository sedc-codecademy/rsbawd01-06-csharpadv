using NewsAppExample.Interface;
using NewsAppExample.Models;

namespace NewsAppExample.Services
{
    public class RSSFeedNewsArticleService : INewsArticleService
    {
        public List<NewsArticle> GetNewsArticles()
        {
            // this is test data test data!!!!

            List<NewsArticle> articles = new List<NewsArticle>();

            articles.Add(new NewsArticle() { Id = 1, Title = "RSS prva vijest", Subtitle = "RSS FEED Prva vijest subtitle" });
            articles.Add(new NewsArticle() { Id = 2, Title = "RSS Druga vijest", Subtitle = "RSS FEED  Druga vijest subtitle" });
            articles.Add(new NewsArticle() { Id = 3, Title = "RSS Treca vijest", Subtitle = "RSS FEED  Treca vijest subtitle" });

            // this is test data test data!!!!

            return articles;
        }
    }
}
