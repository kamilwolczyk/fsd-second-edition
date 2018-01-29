import { Product } from './product';

export class SelectedListItem {
    constructor(
        public product: Product,
        public quantity: number
    ) {}
}
