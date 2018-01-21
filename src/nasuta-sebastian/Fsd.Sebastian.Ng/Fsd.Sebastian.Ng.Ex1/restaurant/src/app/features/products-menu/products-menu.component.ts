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
  }

  removeProduct(product: Product) {
    alert('test');
  }

  getSelectedProduct(product: Product) {
    const select = this.selectedProducts.find(item => item.product.name === product.name);
    return select;
  }

}
