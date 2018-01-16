import { Component, OnInit } from '@angular/core';
import { MenuItem } from '../models/menu-item';

@Component({
  selector: 'app-drinks',
  templateUrl: './drinks.component.html',
  styleUrls: ['./drinks.component.css']
})
export class DrinksComponent implements OnInit {
  drinks: MenuItem[];

  constructor() { }

  ngOnInit() {
    this.drinks = [
      new MenuItem('Woda', 'Woda mineralna niegazowana', 6.00),
      new MenuItem('Sok pomarańczowy', 'Sok z wyciaskanych pomarańczy', 8.00),
      new MenuItem('Cola', 'Coca-cola 0.5l', 4.00),
      new MenuItem('Piwo', 'Warka jasne pełne 0.5l', 7.00),
      new MenuItem('Wódka', 'Żubrówka biała 30cl', 9.00),
    ];
  }

}
