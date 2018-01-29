import { IHello } from "./hello";

export class Person implements IHello {

    constructor(protected firstName: string, private lastName: string) { }

    sayHello(): string {
        return `My name is ${this.firstName} ${this.lastName}`;
    }
}

