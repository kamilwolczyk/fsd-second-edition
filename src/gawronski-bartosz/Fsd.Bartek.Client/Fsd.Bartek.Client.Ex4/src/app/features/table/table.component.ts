import { Component, OnInit, Input } from '@angular/core';
import { Products } from '../../entities/meal';
import { OrderService } from '../table-order/order.service';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {
  @Input() products: Products[];

  constructor(private orderService: OrderService) { }

  ngOnInit() {
  }

  addToOrder(product: Products) {
    this.orderService.addProduct(product);
  }
}
