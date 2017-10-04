import { IProductService } from './productService';
import { Drink, Product } from '../models';
import { Injectable } from '@angular/core';

@Injectable()
export class DrinkService implements IProductService {
  drinks: Drink[];

  constructor() {
    this.drinks = [
      new Drink(11, 'Woda', 'Woda mineralna niegazowana', 6),
      new Drink(12, 'Sok pomarańczowy', 'Sok z wyciskanych pomarańczy', 8),
      new Drink(13, 'Cola', 'Coca-cola 0.5l', 4),
      new Drink(14, 'Piwo', 'Warka jasne pełne 0.5l', 7),
      new Drink(15, 'Wodka', 'Żubrowka biała 30cl', 9),
    ];
  }

  getAllDrinks(): Drink[] {
    return this.drinks;
  }

  public getAllProducts(): Product[] {
    return this.getAllDrinks();
  }
}
