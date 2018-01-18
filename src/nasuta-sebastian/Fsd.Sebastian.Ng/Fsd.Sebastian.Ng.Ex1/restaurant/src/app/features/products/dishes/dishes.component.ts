import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';

@Component({
  selector: 'app-dishes',
  templateUrl: './dishes.component.html',
  styleUrls: ['./dishes.component.css']
})
export class DishesComponent implements OnInit {
  dishes: Product[];

  constructor() { }

  ngOnInit() {
    this.dishes = [
      new Product('Naleśniki po meksykańsku', 'Naleśniki z sosem z pomidorów chilli', 21.00),
      new Product('Spaghetti', 'Makaron z sosem bolognese', 17.50),
      new Product('Pizza peperoni', 'Ciasto z sosem pomidorowym, papryczki peperoni, sos czosnkowy', 24.00),
    ];
  }

}
