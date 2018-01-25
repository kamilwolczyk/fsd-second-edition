import { Injectable } from '@angular/core';
import { Dish } from '../../entities/dishes/dish';

@Injectable()
export class OrderService {
  ordered:Dish[]
  constructor() {
    this.ordered = [];
   }

}
