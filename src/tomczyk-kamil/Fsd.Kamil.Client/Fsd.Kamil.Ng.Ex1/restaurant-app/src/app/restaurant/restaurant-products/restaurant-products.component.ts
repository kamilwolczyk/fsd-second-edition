import { Component, OnInit, Input } from '@angular/core';
import { Product } from '../models/product';
import { ChoiceService } from '../services/choice.service';
import { ProductService } from '../services/product.service';

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
  productService: ProductService;
  drinks: Product[];
  food: Product[];

  constructor(choiceService: ChoiceService) {
    this.choiceService = choiceService;
    this.productService = new ProductService();
  }

  ngOnInit(): void {
    this.buttonClass = 'btn';
    this.changeTableVisibility();

    this.food = this.productService.getFood();
    this.drinks = this.productService.getDrinks();

    // this.drinks = [
    //   new Product(5, "Woda mineralna", "Jurajska", 3, 1),
    //   new Product(6, "Sok", "Pomarańczowy", 4, 1),
    //   new Product(7, "Wino", "Dobre", 12, 1)
    // ]; // tak się nie robi, do serwisu
  }

  changeTableVisibility() {
    this.isTableShown = !this.isTableShown;
    this.statusText = this.isTableShown ? 'Menu' : 'Ukryj'; //nie było w założeniach, w ramach ćwiczenia z zajęć
  }
}