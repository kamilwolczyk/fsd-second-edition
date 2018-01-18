import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';

@Component({
  selector: 'app-drinks',
  templateUrl: './drinks.component.html',
  styleUrls: ['./drinks.component.css']
})
export class DrinksComponent implements OnInit {
  drinks: Product[];

  constructor() { }

  ngOnInit() {
    this.drinks = [
      new Product('Woda', 'Woda mineralna niegazowana', 6.00),
      new Product('Sok pomarańczowy', 'Sok z wyciaskanych pomarańczy', 8.00),
      new Product('Cola', 'Coca-cola 0.5l', 4.00),
      new Product('Piwo', 'Warka jasne pełne 0.5l', 7.00),
      new Product('Wódka', 'Żubrówka biała 30cl', 9.00),
    ];
  }

}
