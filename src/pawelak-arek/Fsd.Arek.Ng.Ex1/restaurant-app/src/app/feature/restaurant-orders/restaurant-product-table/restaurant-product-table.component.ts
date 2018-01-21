import { Component, OnInit, Input } from '@angular/core';
import { ProductService } from '../../../data-source/product.service';
import { Product } from '../../../models/products/product';
import { OrderService } from '../../../models/orders/order.service';

@Component({
  selector: 'app-restaurant-product-table',
  templateUrl: './restaurant-product-table.component.html',
  styleUrls: ['./restaurant-product-table.component.css']
})
export class RestaurantProductTableComponent implements OnInit {

  @Input() product: Product[];

  orderService: OrderService;

  constructor(orderService: OrderService) {
    this.orderService = orderService;
  }

  ngOnInit() {
  }

  addToOrder(product: Product, count: number) {
    this.orderService.addOrderToList(product, count);
  }
}
