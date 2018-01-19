import { Product } from "../product";

export class MainCourse extends Product {
    constructor(public name: string, public description: string, public price) {
        super(name, description, price);
    };
}
