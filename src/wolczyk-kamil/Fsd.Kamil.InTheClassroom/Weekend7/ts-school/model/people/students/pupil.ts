import { Person } from "../person";
import { IPresentable } from "../../../view/presentable";
import { Grade } from "../../subjects/grade";
import { GradeValue } from "../../subjects/gradeValue";
import { Subject } from "../../subjects/subject";

export class Pupil extends Person implements IPresentable {
    grades: Array<Grade>;

    constructor(public firstName: string, public lastName: string, public className: string) {
        super(firstName, lastName);
        this.grades = [];
    }

    show(): string {
        return `Student ${this.getFullName()}`;
    }

    addGrade(subject: Subject, grade: GradeValue): void {
        this.grades.push(new Grade(new Date(), grade));
    }
}