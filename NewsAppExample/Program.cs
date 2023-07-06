using NewsAppExample.Interface;
using NewsAppExample.Models;
using NewsAppExample.Services;
using NewsAppExample.UI;

namespace NewsAppExample;

class Program
{
    static void Main()
    {
        MockNewsArticleService mockNewsArticleService = new MockNewsArticleService(); 
        RSSFeedNewsArticleService rssFeedNewsArticleService = new RSSFeedNewsArticleService();
        NewsArticleService newsArticleService = new NewsArticleService();

        NewsArticlePage newsArticlePage = new NewsArticlePage(newsArticleService);

        newsArticlePage.ShowUI();
    }
}
