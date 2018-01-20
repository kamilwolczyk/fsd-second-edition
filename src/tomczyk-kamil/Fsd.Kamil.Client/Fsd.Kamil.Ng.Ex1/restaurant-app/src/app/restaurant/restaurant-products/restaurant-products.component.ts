import { Component, OnInit, Input } from '@angular/core';
import { Product } from '../models/product';
import { ChoiceService } from '../choice/choice.service';
import { ProductChoice } from '../models/product-choice';

@Component({
  selector: 'app-restaurant-products',
  templateUrl: './restaurant-products.component.html',
  styleUrls: ['./restaurant-products.component.css']
})
export class RestaurantProductsComponent implements OnInit {
  buttonClass: string;
  isTableShown: boolean;
  statusText: string;
  choiceService: ChoiceService;
  @Input() drinks: Product[];
  @Input() food: Product[];
  @Input() choice: ProductChoice[];

  constructor(choiceService: ChoiceService) {
    this.choiceService = choiceService;
    this.choice = [];
  }

  ngOnInit(): void {
    this.buttonClass = 'btn';
    this.changeTableVisibility();

    this.food = [
      new Product(1, "Pizza", "Ser, szynka, pieczarki", 25, 1),
      new Product(2, "Pierogi", "Z owocami", 14, 1),
      new Product(3, "Bigos", "Kapusta, kiełbasa", 12, 1),
      new Product(4, "Hamburger", "Mięso, cebula, sałata, sos", 22, 1)
    ];

    this.drinks = [
      new Product(5, "Woda mineralna", "Jurajska", 3, 1),
      new Product(6, "Sok", "Pomarańczowy", 4, 1),
      new Product(7, "Wino", "Dobre", 12, 1)
    ];
  }

  changeTableVisibility() {
    this.isTableShown = !this.isTableShown;
    this.statusText = this.isTableShown ? 'Menu' : 'Ukryj'; //nie było w założeniach, w ramach ćwiczenia z zajęć
  }

  addActionHasBeenDone(order: Product) {
    let newOrderedProduct: ProductChoice = new ProductChoice(order.name, order.price, 1);
    let existingProduct = this.choiceService.choices.find(o => o.name === newOrderedProduct.name) // odnalezienie produktu,do którego wpisujemy nową ilość
    //Najgorsza część - znalezienie tego produtku, żeby tam dodać ilość
    if (this.choiceService.choices.indexOf(order) === -1) {
      this.choiceService.choices.push(order)
    }
    else {
      existingProduct.quantity++;
    }

    this.summarizeAfterAdding();
  }

  summarizeAfterAdding() {
    this.choiceService.summarizeOrder();
  }
}