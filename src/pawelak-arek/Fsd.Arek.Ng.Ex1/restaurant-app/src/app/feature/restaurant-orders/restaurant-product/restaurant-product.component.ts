import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../../data-source/product.service';
import { Product } from '../../../models/products/product';

@Component({
  selector: 'app-restaurant-product',
  templateUrl: './restaurant-product.component.html',
  styleUrls: ['./restaurant-product.component.css']
})
export class RestaurantProductComponent implements OnInit {

  productService: ProductService;

  drinks: Product[];

  mainCourse: Product[];


  constructor(productService: ProductService) {
    this.productService = productService;
  }

  ngOnInit() {
    this.drinks = this.productService.getDrinks();
    this.mainCourse = this.productService.getMeals();
  }

}
