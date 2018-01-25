import { Injectable } from '@angular/core';
import { Dish } from './entities/dishes/dish';

@Injectable()
export class RestaurantDatabaseService {
  drinks:Dish[];
  dishes:Dish[];

  constructor() { 
    this.drinks = [
      new Dish("Woda", "Woda mineralna, niegazowana 0.5l", 6),
      new Dish("Cola", "Coca-cola 0.5l", 7),
      new Dish("Sok Pomarańczowy", "Świeżo wyciskany sok pomarańczowy 0.33l", 7.50)
    ]

    this.dishes = [
      new Dish("Spaghetti","Makaron z sosem bolognese", 15),
      new Dish("Pizza peperoni","Pizza s sosem pomidorowym, seremi i peperoni", 20),
      new Dish("Naleśniki po meksykańsku","naleśniki na słono z sosem pomidorowym, papryką, kukurydzą i kurczakiem", 21)
    ]
  }

}
