import { Component, OnInit, KeyValueDiffers } from '@angular/core';
import { OrderService } from '../order.service';
import { Dish } from '../../../entities/dishes/dish';
import { DishToDisplay } from '../../../entities/dishes/dish-to-display';
import { HelpersService } from '../../../helpers.service';

@Component({
  selector: 'app-summary',
  templateUrl: './summary.component.html',
  styleUrls: ['./summary.component.css']
})
export class SummaryComponent implements OnInit {
  ordered:Dish[];
  orderedToDisplay: DishToDisplay[];
  differ;
  initialized:boolean; 
  orderPrice:number;

  constructor(private orderService:OrderService, private differs: KeyValueDiffers, private helpers:HelpersService) {
    this.differ = differs.find({}).create();
   }

  ngOnInit() {
    this.ordered = this.orderService.ordered;
    this.initialized = true;
    this.orderedToDisplay = [];
  }

  ngDoCheck() {
    this.ordered = this.orderService.ordered; // Did this because after first remove pointer is losing his target. 

    var changes = this.differ.diff(this.ordered); 
    if (changes && this.initialized) {
      this.mapOrdered(this.ordered)
    }
  } // Used to listen for ordered changes.

  mapOrdered(ordered:Dish[]) {
    let mappedDishes = this.countDishes(ordered); 

    this.orderedToDisplay = mappedDishes;

    this.fullOrderPrice();
  }

  countDishes(ordered:Dish[]) :DishToDisplay[] {
    let counterObjectsArray:DishToDisplay[] = [];

    ordered.forEach( el => {
      if( counterObjectsArray.some( someEl => el.name == someEl.name)) {
        counterObjectsArray.find( someEl => el.name == someEl.name ).addCount();
      }
      else {
        counterObjectsArray.push(new DishToDisplay(el.name, el.description, el.price, 1));
      }
    })

    return counterObjectsArray; 
  }

  removeFromOrder(object:Dish) {
    const mappedObject = new Dish(object.name, object.description, object.price);

    this.orderService.ordered.find( (el, i) => {
      if(JSON.stringify(el) == JSON.stringify(mappedObject)) {
        let firstArray = this.orderService.ordered.slice(0,i);
        let secondArray = this.orderService.ordered.slice(i,this.orderService.ordered.length);
        secondArray.shift();

        this.orderService.ordered = firstArray.concat(secondArray);
        return JSON.stringify(el) == JSON.stringify(mappedObject);
      }
    }) // .find used because i want to remove just one element, not all and I couldn't find better approach.
  }

  fullOrderPrice () {
    this.orderPrice = this.orderedToDisplay.reduce( (previusEl, currentEl) => {
      return previusEl + (currentEl.price* currentEl.displayCount())
    },0)
  }
}
