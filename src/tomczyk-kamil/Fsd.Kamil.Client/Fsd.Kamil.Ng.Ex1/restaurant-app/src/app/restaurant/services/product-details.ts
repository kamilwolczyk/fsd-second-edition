import { Food } from "../models/food";
import { Drink } from "../models/drink";

export class ProductDetails {

  food: Food[];
  drinks: Drink[];

  constructor() {
    this.food = [
      new Food(1, "Pizza", "Ser, szynka, pieczarki", 25, 1),
      new Food(2, "Pierogi", "Z owocami", 14, 1),
      new Food(3, "Bigos", "Kapusta, kiełbasa", 12, 1),
      new Food(4, "Hamburger", "Mięso, cebula, sałata, sos", 22, 1)
    ];

    this.drinks = [
      new Drink(5, "Woda mineralna", "Jurajska", 3, 1),
      new Drink(6, "Sok", "Pomarańczowy", 4, 1),
      new Drink(7, "Wino", "Dobre", 12, 1)
    ];
  }
}