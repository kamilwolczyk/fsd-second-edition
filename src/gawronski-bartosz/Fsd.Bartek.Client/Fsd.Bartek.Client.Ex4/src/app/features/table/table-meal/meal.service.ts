import { Injectable } from '@angular/core';
import { Products } from '../../../entities/meal';


@Injectable()
export class MealService {
  meal: Products[] ;

  constructor() {
    this.meal = [
      new Products('Naleśniki po meksykansku', 'Naleśniki z sosem z pomidorem chilli', 21.00),
      new Products('Spaghetti', 'Makaron z sosem bolognese', 17.50),
      new Products('Pizza peperoni', 'Ciasto z sosem pomidorowym papryczka peperoni sos czosnkowy', 24.00)
    ];
  }

}
