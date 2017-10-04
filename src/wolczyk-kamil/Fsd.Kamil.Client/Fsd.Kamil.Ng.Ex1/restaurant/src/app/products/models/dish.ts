import { Product } from './product';

export class Dish extends Product {
  constructor(
    public id: number,
    public title: string,
    public description: string,
    public price: number) {
    super(id, title, description, price);
  }
}
