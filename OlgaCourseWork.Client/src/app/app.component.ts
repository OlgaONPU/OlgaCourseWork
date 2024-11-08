import { Component, OnInit } from '@angular/core';
import { ProductService } from './services/product.service';
import { TranslateService } from '@ngx-translate/core';
import { ArticleService } from './services/article.service';
import { environment } from '../environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  constructor(
    private productService: ProductService,
    private translate: TranslateService,
    private articleService: ArticleService) {   
  }

  ngOnInit() {
    const lang = localStorage.getItem('lang');
    if (!lang) {
      localStorage.setItem('lang', environment.defaultLocale);
      this.translate.setDefaultLang('en');
      this.translate.use(environment.defaultLocale);
    } else { this.translate.use(lang); }

    this.productService.init();
    this.articleService.init();
  }
}
