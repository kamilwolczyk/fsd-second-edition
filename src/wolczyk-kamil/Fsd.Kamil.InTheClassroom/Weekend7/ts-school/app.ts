import { School } from "./controller/school";
import { ConsolePresenter } from "./view/consolePresenter";
import { MockSchoolData } from "./data-source/mockSchoolData";

const mock:MockSchoolData = new MockSchoolData();
const school:School = new School(mock.subjects, mock.teachers, mock.students);

ConsolePresenter.display(school.peoples);
ConsolePresenter.display(school.subjects);