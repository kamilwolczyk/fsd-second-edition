import { Product } from './product';

export class Drink extends Product {
  constructor(
    public id: number,
    public title: string,
    public description: string,
    public price: number) {
    super(id, title, description, price);
  }
}
