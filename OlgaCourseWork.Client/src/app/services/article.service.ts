import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Article } from '../models/article';

@Injectable()
export class ArticleService {
    private listArticles!: Array<Article>;


    constructor(private http: HttpClient) {
        this.init();
    }
    public init(): Promise<boolean> {
        return new Promise<boolean>((resolve: (value: boolean) => void) => {
            this.http.get('../../assets/articles.json').subscribe(
                (data: any) => {
                    this.listArticles = data;
                    resolve(true);
                }
            );
        });
    }
    
    getList(): Array<Article> {
        return this.listArticles;
    }

    findArticle(id: number): Article | undefined {
        return this.listArticles.find((item) => {
            return item.id == id;
        });
    }
}
