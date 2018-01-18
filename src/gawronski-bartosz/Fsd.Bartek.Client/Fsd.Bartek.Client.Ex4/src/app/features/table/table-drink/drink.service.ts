import { Injectable } from '@angular/core';
import { Products } from '../../../entities/meal';


@Injectable()
export class DrinkService {
  drink: Products[];

  constructor() {
    this.drink = [
      new Products('Woda', 'Woda mineralna niegazowana', 6.00),
      new Products('Sok pomaranczowy', 'Sok wyciskany z pomaranczy', 8.00),
      new Products('Cola', 'Coca-cola 0.5l', 4.00),
      new Products('Piwo', 'Warka jasne pełne 0.5l', 7.00),
      new Products('Wódka', 'Żubrówka biała 0.5l', 9.00)
    ];
  }

}
