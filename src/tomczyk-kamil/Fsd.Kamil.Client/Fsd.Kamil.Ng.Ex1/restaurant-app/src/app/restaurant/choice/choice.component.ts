import { Component, Input } from '@angular/core';
import { ProductChoice } from '../models/product-choice';
import { ChoiceService } from '../services/choice.service';

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

  deleteOrder(id: number) {
    // alert ('działa');
    this.choiceService.deleteFromOrder(id);
  }

  // deleteFromOrder(id: number) {
  //   this.choices = this.choices.filter(item => item.id !== id);
  // }
  // Doczytać o takim sposobie, nie wyszło z filtrowaniem.
}