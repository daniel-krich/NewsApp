import { Component, OnInit } from '@angular/core';
import { NewsService } from '../../services/news.service';
import { RssFeed } from '../../models/RssFeedModel';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit {

  constructor(public newsService : NewsService) { }
  currentDate : Date = new Date();
  ngOnInit() {
      this.newsService.fetchNews();
  }
}
