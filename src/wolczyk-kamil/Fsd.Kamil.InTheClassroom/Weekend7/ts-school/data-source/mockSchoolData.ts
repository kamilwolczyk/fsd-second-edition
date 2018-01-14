import { Subject } from "../model/subjects/subject";
import { Teacher } from "../model/people/employees/teacher";
import { Pupil } from "../model/people/students/pupil";

export class MockSchoolData {
    subjects: Array<Subject>;
    teachers: Array<Teacher>;
    students: Array<Pupil>;

    constructor() {
        const kowalski: Teacher = new Teacher("Jan", "Kowalski");
        const nowak: Teacher = new Teacher("Marian", "Nowak");
        const kaminska: Teacher = new Teacher("Zofia", "Kaminska");

        this.teachers = [
            kowalski,
            nowak,
            kaminska
        ];

        this.subjects = [
            new Subject("Matematyka", kowalski),
            new Subject("Biologia", nowak),
            new Subject("Chemia", kaminska)
        ];

        this.students = [
            new Pupil("Mietek", "Ziobro", "2A"),
            new Pupil("Maria", "Wesola", "1C"),
        ];
    }
}