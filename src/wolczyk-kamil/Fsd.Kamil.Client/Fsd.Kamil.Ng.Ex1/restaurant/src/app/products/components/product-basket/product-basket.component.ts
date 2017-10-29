import { Order } from './order';
import { Product } from '../../models';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'kw-product-basket',
  templateUrl: './product-basket.component.html',
  styleUrls: ['./product-basket.component.css']
})
export class ProductBasketComponent implements OnInit {
  order: Order;

  ngOnInit() {
    this.order = new Order();
  }

  addProduct(product: Product): void {
    this.order.addItem(product);
  }

  removeProduct(product: Product): void {
    this.order.removeItem(product);
  }
}
