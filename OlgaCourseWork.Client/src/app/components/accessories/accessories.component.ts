import { Component } from '@angular/core';
import { Product } from '../../models/product';
import { ProductService } from '../../services/product.service';
import { ProductType } from '../../models/productType';

@Component({
  selector: 'app-accessories',
  templateUrl: './accessories.component.html',
  styleUrl: './accessories.component.scss'
})
export class AccessoriesComponent {

  constructor(private productService: ProductService) { }

  public productsList: Array<Product> = [];

  ngOnInit(): void {
    this.productService.init().then(() => {
      this.productsList = this.productService.getList(ProductType.accessories);
    });
  }
}
