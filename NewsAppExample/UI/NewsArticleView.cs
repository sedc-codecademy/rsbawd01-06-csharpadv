using NewsAppExample.Interface;
using NewsAppExample.Models;

namespace NewsAppExample.UI
{
    public class NewsArticlePage
    {
        private INewsArticleService _service;

        public NewsArticlePage(INewsArticleService service)
        {
            _service = service;
        }

        public void ShowUI() 
        {
            Console.WriteLine(".........................................");
            Console.WriteLine("News portal");
            Console.WriteLine("Todays news items: ");

            foreach (NewsArticle item in _service.GetNewsArticles())
                Console.WriteLine($"{item.Title} ------- {item.Subtitle}");
           
            Console.WriteLine(".........................................");
        }
    }
}
