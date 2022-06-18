using Microsoft.AspNetCore.Mvc;
using NewsApp.Models;
using NewsApp.Services;
using System.Diagnostics;

namespace NewsApp.Controllers
{
    public class NewsController : MainController
    {
        private IRssFetcher _rssFetcher;
        public NewsController(IRssFetcher rssFetcher)
        {
            _rssFetcher = rssFetcher;
        }

        [HttpGet]
        public async Task<ActionResult<RssFeed?>> GetNews()
        {
            return await _rssFetcher.GetFeed();
        }
    }
}