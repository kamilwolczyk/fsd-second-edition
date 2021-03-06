import { Product } from './product';

export class Drink extends Product {
    constructor(
        public id: number,
        public name: string,    
        public details: string,
        public price?: number,
        public quantity?: number) {
        super(id, name, details, price, quantity);
    }
}