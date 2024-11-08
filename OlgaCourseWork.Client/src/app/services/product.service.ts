import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProductsList } from '../models/productsList';
import { Product } from '../models/product';
import { ProductType } from '../models/productType';

@Injectable()
export class ProductService {
    private listProducts!: ProductsList;


    constructor(private http: HttpClient) {
        this.init();
    }
    public init(): Promise<boolean> {
        return new Promise<boolean>(((resolve: (value: boolean) => void)=> {
          this.http.get('../../assets/products.json').subscribe(
                (data: any) => {
                    this.listProducts = data;
                    resolve(true);
                }
            );
        }).bind(this));
    }

    getList(type: ProductType): Array<Product> {
        switch (type) {
            case ProductType.classic: {
                return this.listProducts.classic;
            }
            case ProductType.modern: {
                return this.listProducts.modern;
            }
            case ProductType.country: {
                return this.listProducts.country;
            }
            case ProductType.doors: {
                return this.listProducts.doors;
            }
            case ProductType.accessories: {
                return this.listProducts.accessories;
          }
          default:
            return this.listProducts.accessories;
        }
    }

    findProduct(type: ProductType, id: number): Product   {
        switch (type) {
            case ProductType.classic: {
                return this.listProducts.classic.find((item) => {
                    return item.id == id;
                })!;
            }
            case ProductType.modern: {
                return this.listProducts.modern.find((item) => {
                    return item.id == id;
                })!;
            }
            case ProductType.country: {
                return this.listProducts.country.find((item) => {
                    return item.id == id;
                })!;
            }
            case ProductType.doors: {
                return this.listProducts.doors.find((item) => {
                    return item.id == id;
                })!;
            }
            case ProductType.accessories: {
                return this.listProducts.accessories.find((item) => {
                    return item.id == id;
                })!;
            }
            default:
                return this.listProducts.accessories.find((item) => {
                  return item.id == id;
                })!;
        }
    }

    sendMessage(url:string, data:object) {
        debugger;
        this.http.post(url, data)
            .subscribe(result => {
                debugger;
                var res = result;
            })!;
    }
}
