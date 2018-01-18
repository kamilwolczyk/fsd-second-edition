import { Component, OnInit, Input } from '@angular/core';
import { Product } from '../../products/models/product';
import { SelectedListService } from './selected-list.service';

@Component({
  selector: 'app-selected-list',
  templateUrl: './selected-list.component.html',
  styleUrls: ['./selected-list.component.css']
})
export class SelectedListComponent implements OnInit {
  productService: Product[];

  constructor(selectedService: SelectedListService) {
    this.productService = selectedService.products;
  }

  ngOnInit() {
  }

}
