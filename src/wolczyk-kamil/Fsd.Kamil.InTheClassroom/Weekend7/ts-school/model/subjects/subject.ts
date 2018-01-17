import { Teacher } from "../people/employees/teacher";
import { IPresentable } from "../../view/presentable";

export class Subject implements IPresentable {
    constructor(public name: string, public teacher: Teacher) { }

    show(): string {
        return `Subject ${this.name} developed by teacher ${this.teacher.getFullName()}`;
    }
}