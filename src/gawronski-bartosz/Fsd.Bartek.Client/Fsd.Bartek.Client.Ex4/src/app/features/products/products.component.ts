import { Component, OnInit } from '@angular/core';
import { Products } from '../../entities/meal';
import { DrinkService } from '../table/table-drink/drink.service';
import { OrderService } from '../table-order/order.service';
import { MealService } from '../table/table-meal/meal.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  meal: Products[];
  drink: Products[];

  constructor(private drinkService: DrinkService, private orderService: OrderService, private mealService: MealService) {
    this.drink = drinkService.drink;
    this.meal = mealService.meal;
  }

  ngOnInit() {
  }

}
