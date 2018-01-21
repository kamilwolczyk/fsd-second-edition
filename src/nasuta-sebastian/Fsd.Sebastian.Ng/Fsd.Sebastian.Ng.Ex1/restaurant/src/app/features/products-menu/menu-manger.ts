import { SelectedListItem } from '../models/selected-list-item';
import { Product } from '../models/product';

export class MenuManger {
    selectedProducts: SelectedListItem[];
    totalPrice: number;

    constructor(items: SelectedListItem[]) {
        this.selectedProducts = items;
    }

    addProduct(product: Product) {
        const select = this.getSelectedProduct(product);

        if (select == null) {
            this.selectedProducts.push(new SelectedListItem(product, 1));
        } else {
            select.quantity++;
        }

        this.recalculateBill();
    }

    removeProduct(product: Product) {
        const select = this.getSelectedProduct(product);

        select.quantity--;

        if (select.quantity === 0) {
            this.selectedProducts.splice(this.selectedProducts.indexOf(select), 1);
        }

        this.recalculateBill();
    }

    getSelectedProduct(product: Product) {
        return this.selectedProducts.find(item => item.product.name === product.name);
    }

    recalculateBill() {
        let sum = 0;
        for (let i = 0; i < this.selectedProducts.length; i++) {
            sum = sum + this.selectedProducts[i].product.price * this.selectedProducts[i].quantity;
        }

        this.totalPrice = sum;
    }
}
