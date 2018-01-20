import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from '../models/product';
import { ProductChoice } from '../models/product-choice';

@Component({
  selector: 'app-restaurant-products-list',
  templateUrl: './restaurant-products-list.component.html',
  styleUrls: ['./restaurant-products-list.component.css']
})
export class RestaurantProductsListComponent {

  @Input() food: Product[];
  @Input() drinks: Product[];
  @Input() choice: ProductChoice[];
  @Output() someAction = new EventEmitter();

  constructor() {}

  addToOrder(product: Product) {
    //alert ('działa');
    this.someAction.emit(product);
  }
}