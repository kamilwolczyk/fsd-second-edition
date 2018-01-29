import { Injectable } from '@angular/core';
import { SelectedListItem } from '../models/selected-list-item';

@Injectable()
export class SelectedListService {
  selectedProducts: SelectedListItem[];

  constructor() {
    this.selectedProducts = [];
   }

}
