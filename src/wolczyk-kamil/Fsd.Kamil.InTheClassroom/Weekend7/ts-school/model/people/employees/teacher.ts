import { Person } from "../person";
import { IPresentable } from "../../../view/presentable";

export class Teacher extends Person implements IPresentable {

    constructor(public firstName: string, public lastName: string) {
        super(firstName, lastName);
    }

    show(): string {
        return `Teacher ${this.getFullName()}`;
    }
}