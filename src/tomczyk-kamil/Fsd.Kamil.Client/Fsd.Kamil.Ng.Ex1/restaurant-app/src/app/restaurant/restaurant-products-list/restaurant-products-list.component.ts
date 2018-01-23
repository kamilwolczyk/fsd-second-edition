import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Product } from '../models/product';
import { ProductChoice } from '../models/product-choice';
import { ChoiceService } from '../services/choice.service';

@Component({
  selector: 'app-restaurant-products-list',
  templateUrl: './restaurant-products-list.component.html',
  styleUrls: ['./restaurant-products-list.component.css']
})
export class RestaurantProductsListComponent {

  @Input() food: Product[];
  @Input() drinks: Product[];
  @Input() products: Product[];
  @Input() choice: ProductChoice[];
  // @Output() someAction = new EventEmitter(); //rezygnacja z Emittera
  choiceService: ChoiceService;

  constructor(choiceService: ChoiceService) {
    this.choiceService = choiceService;
  }

  addToOrder(product: Product) {
    // this.someAction.emit(product); //rezygnacja z Emittera
    this.choiceService.addProductToOrder(product);
  }
}