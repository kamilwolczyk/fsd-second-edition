import { Injectable } from '@angular/core';
import { Product } from '../models/product';

@Injectable()
export class DishesService {
  dishes: Product[];

  constructor() {
    this.dishes = [
      new Product('Naleśniki po meksykańsku', 'Naleśniki z sosem z pomidorów chilli', 21.00),
      new Product('Spaghetti', 'Makaron z sosem bolognese', 17.50),
      new Product('Pizza peperoni', 'Ciasto z sosem pomidorowym, papryczki peperoni, sos czosnkowy', 24.00),
    ];
  }

}
