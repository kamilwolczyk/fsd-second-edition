import { Component, OnInit } from '@angular/core';
import { RestaurantDatabaseService } from '../../restaurant-database.service';
import { TablesClass } from '../tables-class';

@Component({
  selector: 'app-container',
  templateUrl: './container.component.html',
  styleUrls: ['./container.component.css']
})
export class ContainerComponent implements OnInit {
  tables:TablesClass[]

  constructor(private restaurantDatabase:RestaurantDatabaseService) { }

  ngOnInit() {
    this.tables = [
      new TablesClass("Jedznie",this.restaurantDatabase.dishes),
      new TablesClass("Picie",this.restaurantDatabase.drinks) 
    ]
  }
}
