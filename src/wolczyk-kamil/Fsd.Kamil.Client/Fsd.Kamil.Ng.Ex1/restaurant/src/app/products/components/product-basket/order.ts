import { Product } from "app/products";

export class OrderItem {

  constructor(public product: Product, public quantity: number) { }
}

export class Order {

  items: OrderItem[];
  totalPrice: number;

  constructor() {
    this.items = [];
  }

  addItem(product: Product): void {
    let order = this.getOrder(product);

    if (order == null) {
      order = new OrderItem(product, 0);
      this.items.push(order);
    }

    order.quantity++;
    this.calculateTotals();
  }

  removeItem(product: Product): void {
    const order = this.getOrder(product);

    if (order == null) {
      throw new Error(`Order for product ${product.title} has not been found`);
    }

    order.quantity--;

    if (order.quantity === 0) {
      this.items = this.items.filter(item => item.product.id != order.product.id);
    }

    this.calculateTotals();
  }

  private getOrder(product: Product): OrderItem {
    const products = this.items.filter(order => order.product.id === product.id);
    return products != null && products.length > 0 ? products[0] : null;
  }

  private calculateTotals() {
    this.totalPrice = this.items.map(order => order.quantity * order.product.price).reduce((a, b) => a + b, 0);
  }
}
