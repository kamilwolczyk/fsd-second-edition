import { IHello } from "./hello";
import { Person } from "./person";
import { Status } from "./status";

export class Employee extends Person implements IHello {
    currentStatus: Status;

    constructor(firstName: string, lastName: string, private companyName: string) {
        super(firstName, lastName);
        this.currentStatus = Status.New;
    }

    sayHello(): string {
        return `${this.firstName} and I am working in ${this.companyName}`;
    }

    fire(): void {
        this.currentStatus = Status.Fired;
    }
}