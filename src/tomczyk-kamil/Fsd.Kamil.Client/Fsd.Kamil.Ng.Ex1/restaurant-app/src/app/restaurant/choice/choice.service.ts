import { Injectable } from '@angular/core';
import { ProductChoice } from '../models/product-choice';

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
}