import { Component, OnInit } from '@angular/core';
import { Article } from '../../models/article';
import { ArticleService } from '../../services/article.service';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss']
})
export class ArticlesComponent implements OnInit {
  public articlesList: Array<Article> = [];

  constructor(private articleService: ArticleService) { }

  ngOnInit(): void {
    this.articleService.init()
      .then((data) => {
        this.articlesList = this.articleService.getList();
      });
  }

}
