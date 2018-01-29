import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from '../../models/product';

@Component({
  selector: 'app-menu-list',
  templateUrl: './menu-list.component.html',
  styleUrls: ['./menu-list.component.css']
})
export class MenuListComponent {
  @Input() items: Product[];
  @Output() selectionEvent = new EventEmitter();

  selectItem(product: Product) {
    this.selectionEvent.emit(product);
  }
}
