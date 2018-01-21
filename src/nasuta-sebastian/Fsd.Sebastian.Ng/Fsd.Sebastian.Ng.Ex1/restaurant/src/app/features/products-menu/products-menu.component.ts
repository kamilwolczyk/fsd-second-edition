import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { SelectedListItem } from '../models/selected-list-item';
import { SelectedListService } from '../services/selected-list.service';

@Component({
  selector: 'app-products-menu',
  templateUrl: './products-menu.component.html',
  styleUrls: ['./products-menu.component.css']
})
export class ProductsMenuComponent implements OnInit {
  dishes: Product[];
  drinks: Product[];
  totalPrice: number;

  selectedProducts: SelectedListItem[];

  constructor(selectedService: SelectedListService) {
    this.selectedProducts = selectedService.selectedProducts;
  }

  ngOnInit() {
    this.dishes = [
      new Product('Naleśniki po meksykańsku', 'Naleśniki z sosem z pomidorów chilli', 21.00),
      new Product('Spaghetti', 'Makaron z sosem bolognese', 17.50),
      new Product('Pizza peperoni', 'Ciasto z sosem pomidorowym, papryczki peperoni, sos czosnkowy', 24.00),
    ];
    this.drinks = [
      new Product('Woda', 'Woda mineralna niegazowana', 6.00),
      new Product('Sok pomarańczowy', 'Sok z wyciaskanych pomarańczy', 8.00),
      new Product('Cola', 'Coca-cola 0.5l', 4.00),
      new Product('Piwo', 'Warka jasne pełne 0.5l', 7.00),
      new Product('Wódka', 'Żubrówka biała 30cl', 9.00),
    ];
  }

  selectProduct(product: Product) {
    const select = this.getSelectedProduct(product);

    if (select == null) {
      this.selectedProducts.push(new SelectedListItem(product, 1));
    } else {
      select.quantity++;
    }

    this.recalculateBill();
  }

  removeProduct(product: Product) {
    const select = this.getSelectedProduct(product);

    select.quantity--;

    if (select.quantity === 0) {
      this.selectedProducts.splice(this.selectedProducts.indexOf(select), 1);
    }

    this.recalculateBill();
  }

  getSelectedProduct(product: Product) {
    return this.selectedProducts.find(item => item.product.name === product.name);
  }

  recalculateBill() {
    let sum = 0;
    for (let i = 0; i < this.selectedProducts.length; i++) {
      sum = sum + this.selectedProducts[i].product.price * this.selectedProducts[i].quantity;
    }

    this.totalPrice = sum;
  }

}
