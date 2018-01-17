import { IPresentable } from "../../view/presentable";

export class Person implements IPresentable {
    constructor(public firstName: string, public lastName: string) { }

    getFullName(): string {
        return `${this.firstName} ${this.lastName}`;
    }

    show(): string {
        return this.getFullName();
    }
}