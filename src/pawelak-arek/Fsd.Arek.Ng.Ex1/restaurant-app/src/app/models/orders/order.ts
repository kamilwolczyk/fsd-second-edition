import { Product } from "../products/product";

export class Order {

    orderItem: Product
    count: number;

    constructor(product: Product, count: number) {
        this.orderItem = product;
        this.count = count;
    }
}
