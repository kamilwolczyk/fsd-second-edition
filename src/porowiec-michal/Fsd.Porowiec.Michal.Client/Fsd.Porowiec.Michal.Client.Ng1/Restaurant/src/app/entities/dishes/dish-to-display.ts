import { Dish } from "./dish";

export class DishToDisplay extends  Dish {
    constructor(public readonly name:string, public readonly description, public readonly number:number, private count:number ) {
        super(name,description,number)
    }

    addCount() {
        this.count++
    }

    displayCount() {
        return this.count;
    }
}
