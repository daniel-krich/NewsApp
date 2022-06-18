export interface RssFeed {
    rss: RssObj;
}

export interface RssObj {
    version: string;
    channel: RssChannel;
}

export interface RssChannel {
    title: string;
    category: string;
    lastBuildDate: string;
    items: Array<RssItem>;
}

export interface RssItem {
    id: string;
    title: string;
    description: string;
    author: string;
    image: string;
    link: string;
    publishDate: Date;
    fullText: string;
    genre: string;
    tags: string;
}