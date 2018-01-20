import { Component, OnInit, Input } from '@angular/core';
import { ChoiceService } from './choice.service';
import { ProductChoice } from '../models/product-choice';

@Component({
  selector: 'app-choice',
  templateUrl: './choice.component.html',
  styleUrls: ['./choice.component.css']
})
export class ChoiceComponent {

  choiceService: ChoiceService;
  @Input() choices: ProductChoice[]

  //Tu poniżej w konstruktorze albo daję "private" albo wcześniej choiceService: ChoiceService
  constructor(choiceService: ChoiceService) {
    this.choiceService = choiceService;
    this.choices = choiceService.choices;
  }

  deleteFromOrder(id: number) {
    if (this.choices[id].quantity === 1) {
      this.choices.splice(id, 1); //całkowite usunięcie     
    } 
    else {
      this.choices[id].quantity--; // zmniejszenie tylko ilości, bo mamy jeszcze coś w koszyku
    }

    this.summarizeAfterDeleting();
  }

  summarizeAfterDeleting() {
    this.choiceService.summarizeOrder();
  }

  // deleteFromOrder(id: number) {
  //   this.choices = this.choices.filter(item => item.id !== id);
  // }
  // Doczytać o takim sposobie, nie wyszło z filtrowaniem.
}