import { Teacher } from "../people/employees/teacher";
import { Pupil } from "../people/students/pupil";

export class SchoolClass {
    constructor(public name: string, public teacher: Teacher, public students: Array<Pupil>) { }
}