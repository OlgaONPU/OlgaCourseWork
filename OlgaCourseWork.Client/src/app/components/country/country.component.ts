import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { Product } from '../../models/product';
import { ProductType } from '../../models/productType';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.scss']
})
export class CountryComponent implements OnInit {

  constructor(private productService: ProductService) { }

  public productsList: Array<Product> = [];

  ngOnInit(): void {
    this.productService.init().then(() => {
      this.productsList = this.productService.getList(ProductType.country);
    });
  }

}
