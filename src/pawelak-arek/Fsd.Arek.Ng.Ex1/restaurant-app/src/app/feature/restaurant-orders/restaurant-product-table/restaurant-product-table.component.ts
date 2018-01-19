import { Component, OnInit, Input } from '@angular/core';
import { ProductService } from '../../../data-source/product.service';
import { Product } from '../../../models/products/product';

@Component({
  selector: 'app-restaurant-product-table',
  templateUrl: './restaurant-product-table.component.html',
  styleUrls: ['./restaurant-product-table.component.css']
})
export class RestaurantProductTableComponent implements OnInit {

@Input() product: Product[];

  constructor() {
  }

  ngOnInit() {
  }

}
