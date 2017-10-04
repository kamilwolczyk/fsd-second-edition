import { IProductService } from './productService';
import { Dish, Product } from '../models';
import { Injectable } from '@angular/core';

@Injectable()
export class DishService implements IProductService {

  dishes: Dish[];

  constructor() {
    this.dishes = [
      new Dish(1, 'Naleśniki po meksykańsku', 'Naleśniki z sosem z pomidorw chilli', 21),
      new Dish(2, 'Spaghetti', 'Makaron z sosem bolognese', 17.5),
      new Dish(3, 'Pizza peperoni', 'Ciasto z sosem pomidorowym, papryczki peperoni, sos czosnkowy', 24),
    ];
  }

  getAllDishes(): Dish[] {
    return this.dishes;
  }

  getAllProducts(): Product[] {
    return this.getAllDishes();
  }
}
