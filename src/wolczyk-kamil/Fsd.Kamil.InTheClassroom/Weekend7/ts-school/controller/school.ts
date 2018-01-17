import { Person } from "../model/people/person";
import { Subject } from "../model/subjects/subject";
import { Teacher } from "../model/people/employees/teacher";
import { Pupil } from "../model/people/students/pupil";

export class School {
    peoples: Array<Person>;
    subjects: Array<Subject>;

    constructor(subjects: Array<Subject>, teachers: Array<Teacher>, students: Array<Pupil>) {
        this.subjects = subjects;
        this.peoples = teachers;
     }
}