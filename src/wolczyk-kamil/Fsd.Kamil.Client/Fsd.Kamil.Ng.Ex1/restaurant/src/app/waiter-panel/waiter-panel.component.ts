import { ProductBasketComponent } from '../products/components/product-basket/product-basket.component';
import { Product } from '../products/models';
import { ProductListConfiguration } from '../products/components/product-list/productListConfiguration';
import { DishService, DrinkService } from '../products';
import { Component, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'kw-waiter-panel',
  templateUrl: './waiter-panel.component.html',
  styleUrls: ['./waiter-panel.component.css']
})
export class WaiterPanelComponent implements OnInit {

  dishListConfig: ProductListConfiguration;
  drinkListConfig: ProductListConfiguration;

  @ViewChild(ProductBasketComponent) basket: ProductBasketComponent;

  constructor(private dishService: DishService, private drinkService: DrinkService) { }

  ngOnInit() {
    this.dishListConfig = new ProductListConfiguration(this.dishService);
    this.drinkListConfig = new ProductListConfiguration(this.drinkService);
  }

  addProductToBasket(product: Product): void {
    this.basket.addProduct(product);
  }
}
