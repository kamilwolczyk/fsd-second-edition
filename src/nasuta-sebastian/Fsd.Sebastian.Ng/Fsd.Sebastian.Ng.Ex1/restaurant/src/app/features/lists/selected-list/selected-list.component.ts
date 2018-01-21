import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from '../../models/product';
import { SelectedListItem } from '../../models/selected-list-item';

@Component({
  selector: 'app-selected-list',
  templateUrl: './selected-list.component.html',
  styleUrls: ['./selected-list.component.css']
})
export class SelectedListComponent implements OnInit {
  @Input() items: SelectedListItem[];
  @Input() totalPrice: number;
  @Output() selectionEvent = new EventEmitter();

  constructor() {
  }

  ngOnInit() {
  }

  removeItem(item: Product) {
    this.selectionEvent.emit(item);
  }
}
