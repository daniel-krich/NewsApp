import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { RssFeed, RssObj, RssItem } from '../models/RssFeedModel';
import * as rssObj from '../../assets/dummyNews.json';

@Injectable({
  providedIn: 'root'
})

export class NewsService {

    constructor(private http : HttpClient) { }
    currentFeed : RssFeed | undefined;
    currentArticle : RssItem | undefined;
    fetchNews() {
        this.currentArticle = undefined;
        this.currentFeed = undefined;//{ rss: rssObj as unknown} as RssFeed;
        const subr = this.http.get('/api/news', { responseType: 'text' }).pipe(
          catchError(this.handleHttpError)
        ).subscribe(async (Response) => {
            this.currentFeed = { rss: JSON.parse(Response) as unknown} as RssFeed;
            subr.unsubscribe();
        });
    }

    viewArticle(articleId: number) {
        this.currentArticle = this.currentFeed?.rss.channel.items.find((val, index) => index == articleId);
    }

    handleHttpError (error : HttpErrorResponse) {
        if(error.error instanceof ErrorEvent) {
            console.error("Front request error: ", error.error.message);
        }
        else console.error("Back request error");
        return throwError("Http request error occured");
    }
}
