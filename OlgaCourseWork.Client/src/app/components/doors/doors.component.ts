import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { Product } from '../../models/product';
import { ProductType } from '../../models/productType';

@Component({
  selector: 'app-doors',
  templateUrl: './doors.component.html',
  styleUrls: ['./doors.component.scss']
})
export class DoorsComponent implements OnInit {

  constructor(private productService: ProductService) { }

  public productsList: Array<Product> = [];

  ngOnInit(): void {
    this.productService.init().then(() => {
      this.productsList = this.productService.getList(ProductType.doors);
    });
  }

}
