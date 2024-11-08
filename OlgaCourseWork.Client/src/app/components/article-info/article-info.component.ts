import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Article } from '../../models/article';
import { ArticleService } from '../../services/article.service';
import $ from "jquery";

@Component({
  selector: 'app-article-info',
  templateUrl: './article-info.component.html',
  styleUrls: ['./article-info.component.scss']
})
export class ArticleInfoComponent implements OnInit, OnDestroy {

  private routeSub!: Params;
  public articleId!: number;
  public article!: Article;
  constructor(
    private route: ActivatedRoute,
    private articleServise: ArticleService) { }

  ngOnInit() {
    this.routeSub = this.route.params.subscribe(params => {
      this.articleId = params['id'];

      this.articleServise.init().then(() => {
        this.article = this.articleServise.findArticle(this.articleId) as Article;
      });
    });
    setTimeout(this.setStyle, 200);
  }

  setStyle() {
    const tube = $(".tube");
    if (tube.length !== 0)
      tube.css({ "max-width": "800px", "margin": "10px" });
    else
      $(".float-right").css({ "max-width": "300px", "margin": "10px" });

    $(".float-left").css({ "max-width": "300px", "margin": "10px" });

  }

  ngOnDestroy() {
    // this.routeSub.unsubscribe();
  }
}
