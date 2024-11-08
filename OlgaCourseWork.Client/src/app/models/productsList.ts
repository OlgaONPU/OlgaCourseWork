import { Product } from './product';


export interface ProductsList {
    accessories:  Array<Product>;
    modern: Array<Product>;
    classic: Array<Product>;
    country: Array<Product>;
    doors: Array<Product>;
}
