import { Injectable } from '@angular/core';
import { Product } from '../models/products/product';
import { MockProductData } from './mock-product-data';

@Injectable()
export class ProductService {

  productDb: MockProductData;

  constructor() {
    this.productDb = new MockProductData();
  }

  getDrinks(): Array<Product> {
    return this.productDb.drinks;
  }

  getMeals(): Array<Product> {
    return this.productDb.meals;
  }

}
