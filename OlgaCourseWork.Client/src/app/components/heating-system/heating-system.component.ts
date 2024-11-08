import { Component, OnInit } from '@angular/core';
// import { Ng7BootstrapBreadcrumbService } from 'ng7-bootstrap-breadcrumb';
import { TranslateService } from '@ngx-translate/core';
import { ProductService } from '../../services/product.service';
import { Product } from '../../models/product';
import { ProductType } from '../../models/productType';

@Component({
  selector: 'app-heating-system',
  templateUrl: './heating-system.component.html',
  styleUrls: ['./heating-system.component.scss']
})
export class HeatingSystemComponent implements OnInit {

  constructor(
    private heatingService: ProductService,
    // private breadcrumbService: Ng7BootstrapBreadcrumbService,
    private translate: TranslateService) { }

  public productsList: Array<Product> = [];

  ngOnInit(): void {
    this.heatingService.init().then(() => {
      this.productsList = this.heatingService.getList(ProductType.heatingSystem);
    });

    let breadcrumb = { customText: '', dynamicText: '' };
    this.translate.get("NAV.HOME").subscribe((res) => {
      breadcrumb.dynamicText = res;
    });

    this.translate.get("STYLE.HEATINGSYSTEM").subscribe((res) => {
      breadcrumb.customText = res;
    });
    // this.breadcrumbService.updateBreadcrumbLabels(breadcrumb);
  }

}
