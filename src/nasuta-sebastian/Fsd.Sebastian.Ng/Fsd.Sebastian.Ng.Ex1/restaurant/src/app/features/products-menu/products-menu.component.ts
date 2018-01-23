import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { SelectedListItem } from '../models/selected-list-item';
import { SelectedListService } from '../services/selected-list.service';
import { DishesService } from '../services/dishes.service';
import { DrinksService } from '../services/drinks.service';
import { MenuManger } from './menu-manger';

@Component({
  selector: 'app-products-menu',
  templateUrl: './products-menu.component.html',
  styleUrls: ['./products-menu.component.css']
})
export class ProductsMenuComponent implements OnInit {
  dishes: Product[];
  drinks: Product[];
  selectedProducts: SelectedListItem[];
  menuManager: MenuManger;

  constructor(selectedService: SelectedListService, dishesService: DishesService, drinksService: DrinksService) {
    this.dishes = dishesService.dishes;
    this.drinks = drinksService.drinks;
    this.selectedProducts = selectedService.selectedProducts;
  }

  ngOnInit() {
    this.menuManager = new MenuManger(this.selectedProducts);
    }

  selectProduct(product: Product) {
    this.menuManager.addProduct(product);
  }

  unselectProduct(product: Product) {
    this.menuManager.removeProduct(product);
  }
}
