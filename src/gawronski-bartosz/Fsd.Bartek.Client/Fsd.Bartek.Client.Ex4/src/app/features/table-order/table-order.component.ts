import { Component, OnInit } from '@angular/core';
import { Products } from '../../entities/meal';
import { OrderService } from './order.service';
import { ProductOrder } from '../../entities/product-order';

@Component({
  selector: 'app-table-order',
  templateUrl: './table-order.component.html',
  styleUrls: ['./table-order.component.css']
})
export class TableOrderComponent implements OnInit {
  order: ProductOrder[];
  price: number;

  constructor(private orderService: OrderService) {
    this.order = this.orderService.orderProduct;
    this.price = 0;
   }

  ngOnInit() {
  }

  deleteOrder(index: number) {
    this.orderService.deleteProduct(index);
  }

}
