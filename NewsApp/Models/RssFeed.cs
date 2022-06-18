using System.Xml;
using System.Xml.Serialization;

namespace NewsApp.Models
{
    [XmlRoot("rss")]
    public class RssFeed
    {
        [XmlAttribute("version")]
        public string? Version { get; set; }

        [XmlElement("channel")]
        public RssChannel? Channel { get; set; }
    }

    public class RssChannel
    {
        [XmlElement("title")]
        public string? Title { get; set; }

        [XmlElement("link")]
        public string? Link { get; set; }

        [XmlElement("lastBuildDate")]
        public string? LastBuildDate { get; set; }

        [XmlElement("item")]
        public RssItem[]? Items { get; set; }
    }

    public class RssItem
    {
        [XmlElement("id")]
        public string? Id { get; set; }

        [XmlElement("title")]
        public string? Title { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("author")]
        public string? Author { get; set; }

        [XmlElement("image")]
        public string? Image { get; set; }

        [XmlElement("link")]
        public string? Link { get; set; }

        [XmlElement("pubDate")]
        public string? PublishDate { get; set; }

        [XmlElement("full-text")]
        public string? FullText { get; set; }

        [XmlElement("tags")]
        public string? Tags { get; set; }

        [XmlElement("genre")]
        public string? Genre { get; set; }
    }
}
