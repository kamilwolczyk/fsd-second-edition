import { Injectable } from '@angular/core';
import { ProductDetails } from './product-details';
import { Product } from '../models/product';

@Injectable()
export class ProductService {

  productDetails: ProductDetails

  constructor() { 
    this.productDetails = new ProductDetails();
  }

  getFood(): Product[] {
    return this.productDetails.food;
  }

  getDrinks(): Product[] {
    return this.productDetails.drinks;
  }
}