import { Component, OnInit } from '@angular/core';
import { MenuItem } from '../models/menu-item';

@Component({
  selector: 'app-dishes',
  templateUrl: './dishes.component.html',
  styleUrls: ['./dishes.component.css']
})
export class DishesComponent implements OnInit {
  dishes: MenuItem[];

  constructor() { }

  ngOnInit() {
    this.dishes = [
      new MenuItem('Naleśniki po mwksykańsku', 'Naleśniki z sosem z pomidorów chilli', 21.00),
      new MenuItem('Spaghetti', 'Makaron z sosem bolognese', 17.50),
      new MenuItem('Pizza peperoni', 'Ciasto z sosem pomidorowym, papryczki peperoni, sos czosnkowy', 24.00),
    ];
  }

}
