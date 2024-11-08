import { Component, OnInit } from '@angular/core';
// import { Ng7BootstrapBreadcrumbService } from 'ng7-bootstrap-breadcrumb';
import { TranslateService } from '@ngx-translate/core';
import { ProductService } from '../../services/product.service';
import { Product } from '../../models/product';
import { ProductType } from '../../models/productType';

@Component({
  selector: 'app-modern',
  templateUrl: './modern.component.html',
  styleUrls: ['./modern.component.scss']
})
export class ModernComponent implements OnInit {

  constructor(
    private productService: ProductService,
    // private breadcrumbService: Ng7BootstrapBreadcrumbService,
    private translate: TranslateService) { }

  public productsList: Array<Product> = [];

  ngOnInit(): void {
    this.productService.init().then(() => {
      this.productsList = this.productService.getList(ProductType.modern);
    });

    let breadcrumb = { customText: '', dynamicText: '' };
    this.translate.get("NAV.HOME").subscribe((res) => {
      breadcrumb.dynamicText = res;
    });

    this.translate.get("STYLE.MODERN").subscribe((res) => {
      breadcrumb.customText = res;
    });
    // this.breadcrumbService.updateBreadcrumbLabels(breadcrumb);
  }

}
