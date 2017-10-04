export abstract class Product {
  constructor(
    public id: number,
    public title: string,
    public description: string,
    public price: number) { }
}
