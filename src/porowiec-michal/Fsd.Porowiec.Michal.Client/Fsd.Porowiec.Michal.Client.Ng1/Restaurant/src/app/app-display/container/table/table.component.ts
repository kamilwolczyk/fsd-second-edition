import { Component, OnInit, Input } from '@angular/core';
import { Dish } from '../../../entities/dishes/dish';
import { TablesClass } from '../../tables-class';
import { OrderService } from '../order.service';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {
  @Input() tableInfo:TablesClass;
  tablePositions: Dish[];

  constructor(private orderService:OrderService) { }

  ngOnInit() {
    this.tablePositions = this.tableInfo.tablePositions;
  }

  AddToOrder(dish: Dish) {
    this.orderService.ordered.push(dish);
  }
}
