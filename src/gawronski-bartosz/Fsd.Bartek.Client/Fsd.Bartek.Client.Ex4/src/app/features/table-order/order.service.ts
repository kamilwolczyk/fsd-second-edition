import { Injectable } from '@angular/core';
import { Products } from '../../entities/meal';
import { ProductOrder } from '../../entities/product-order';

@Injectable()
export class OrderService {
  orderProduct: ProductOrder[];
  totalPrice: number;


  constructor() {
    this.orderProduct = [];
    this.totalPrice= 0;
  }

  addProduct(product: Products) {
    let newProduct: ProductOrder = this.productMapping(product);
    let findProduct: ProductOrder = this.findProduct(newProduct);

    if (findProduct === undefined) {
      this.orderProduct.push(newProduct);
    }else {
      findProduct.many++;
    }
    this.calculatePrice();
  }

  deleteProduct(index: number) {
    if(this.orderProduct[index].many === 1) {
      this.orderProduct.splice(index, 1);
    }else {
      this.orderProduct[index].many--;
    }
    this.calculatePrice();
  }

  productMapping(product: Products) {
    return new ProductOrder(product.name , product.price, 1);
  }

  findProduct(newProduct) {
    return this.orderProduct
      .find(
        (el) => {
          if (el.name === newProduct.name) {
            return true;
          }
          return false;
        }
      );
  }

  calculatePrice() {
    this.totalPrice = this.orderProduct.map(order => order.many * order.price).reduce((a, b) => a + b, 0);
  }
}
