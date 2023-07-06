using NewsAppExample.Models;

namespace NewsAppExample.Interface
{
    public interface INewsArticleService
    {
        public List<NewsArticle> GetNewsArticles();
    }
}
