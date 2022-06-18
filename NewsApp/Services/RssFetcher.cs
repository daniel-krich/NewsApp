using NewsApp.Models;
using System.Text.Json;
using System.Xml.Serialization;

namespace NewsApp.Services
{
    public interface IRssFetcher
    {
        Task<RssFeed?> GetFeed();
    }

    public class RssFetcher : IRssFetcher
    {
        private const string RssUrl = "http://www.ynet.co.il/Integration/StoryRss2.xml";

        private RssFeed? _feed;

        public async Task<RssFeed?> GetFeed()
        {
            if (_feed == null)
            {
                using (HttpClient client = new HttpClient())
                {
                    using Stream xmlResult = await client.GetStreamAsync(RssUrl);
                    var serializer = new XmlSerializer(typeof(RssFeed));
                    _feed = serializer.Deserialize(xmlResult) as RssFeed;
                }
            }
            return _feed;
        }
    }
}
