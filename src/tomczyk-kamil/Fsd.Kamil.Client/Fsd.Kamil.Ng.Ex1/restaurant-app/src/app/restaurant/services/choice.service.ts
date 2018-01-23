import { Injectable } from '@angular/core';
import { ProductChoice } from '../models/product-choice';
import { Product } from '../models/product';

@Injectable()
export class ChoiceService {

  choices: ProductChoice[];
  total: number;

  constructor() {
    this.choices = [];
    this.total = 0;
  }

  summarizeOrder() {
    this.total = this.choices.map(order => order.quantity * order.price)
      .reduce((x, y) => x + y, 0); //ciekawe, trudne - doczytać jeszcze, zsumowanie wartości z tablicy wcześniej "zmapowanej"
  }
  // Metoda map() tworzy nową tablicę zawierającą wyniki wywoływania podanej funkcji 
  // dla każdego elementu wywołującej tablicy.

  // Metoda reduce() wywołuje funkcję względem wartości przyrostowej 
  // z każdego wywołania i kolejnego elementu tablicy (od lewej do prawej) 
  // w celu sprowadzenia tej tablicy do pojedynczej wartości.
  // 0 to initialize value tutaj.

  // addActionHasBeenDone(order: Product) {
  addProductToOrder(order: Product) {
    let newOrderedProduct: ProductChoice = new ProductChoice(order.name, order.price, 1);
    let existingProduct = this.choices.find(o => o.name === newOrderedProduct.name) // odnalezienie produktu,do którego wpisujemy nową ilość
    //Trudna część - znalezienie tego produtku, żeby tam dodać ilość
    if (this.choices.indexOf(order) === -1) {
      this.choices.push(order)
    }
    else {
      existingProduct.quantity++;
    }

    this.summarizeOrder();
  }

  deleteFromOrder(id: number) {
    if (this.choices[id].quantity === 1) {
      this.choices.splice(id, 1); //całkowite usunięcie     
    }
    else {
      this.choices[id].quantity--; // zmniejszenie tylko ilości, bo mamy jeszcze coś w koszyku
    }

    this.summarizeOrder();
  }
}