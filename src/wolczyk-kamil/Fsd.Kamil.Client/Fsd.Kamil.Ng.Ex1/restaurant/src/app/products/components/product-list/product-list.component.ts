import { ProductListConfiguration } from './productListConfiguration';
import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { Product } from "app/products";

@Component({
  selector: 'kw-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  items: Product[];
  @Input() configuration: ProductListConfiguration;
  @Output() productSelectAction = new EventEmitter();

  ngOnInit() {
    this.items = this.configuration.service.getAllProducts();
  }

  selectProduct(product: Product): void {
    this.productSelectAction.emit(product);
  }
}
