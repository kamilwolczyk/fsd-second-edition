import { IHello } from "./hello";
import { Employee } from "./employee";
import { Presenter } from "./presenter";
import { HttpClient } from "./httpClient";
import { Question, Quiz } from "./quiz";

let kamil: IHello = new Employee("Kamil", "Wołczyk", "AC Project");
console.log(kamil.sayHello());

let presenter: Presenter = new Presenter("Time is up", 2000);
presenter.start((text: string) => {
    console.log(text);
});


const promise:Promise<Array<Question>> = HttpClient.getFromServer("http://sample.api.com/users");

promise.then((questions: Array<Question>) => {
    const quiz: Quiz = new Quiz(questions);
    quiz.start();
});

console.log("C");