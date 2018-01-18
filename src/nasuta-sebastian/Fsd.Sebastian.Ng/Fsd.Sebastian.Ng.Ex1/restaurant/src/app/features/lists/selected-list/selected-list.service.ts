import { Injectable } from '@angular/core';
import { Product } from '../../products/models/product';

@Injectable()
export class SelectedListService {
  products: Product[];

  constructor() {
    this.products = [];
   }

}
