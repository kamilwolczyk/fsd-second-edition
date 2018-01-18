import { Component, OnInit, Input } from '@angular/core';
import { Product } from '../../products/models/product';
import { Output } from '@angular/core/src/metadata/directives';
import { SelectedListService } from '../selected-list/selected-list.service';

@Component({
  selector: 'app-menu-list',
  templateUrl: './menu-list.component.html',
  styleUrls: ['./menu-list.component.css']
})
export class MenuListComponent implements OnInit {
  @Input() items: Product[];
  selectedService: SelectedListService;

  constructor(selectedService: SelectedListService) {
    this.selectedService = selectedService;
   }

  ngOnInit() {
  }

  selectItem(item) {
    this.selectedService.products.push(item);
  }
}
