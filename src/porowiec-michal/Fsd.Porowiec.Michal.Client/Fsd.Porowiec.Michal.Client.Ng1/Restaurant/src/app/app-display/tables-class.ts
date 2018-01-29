import { Dish } from "../entities/dishes/dish";

export class TablesClass {
    constructor(public readonly tableName:string, public readonly tablePositions:Dish[] ){}
}
