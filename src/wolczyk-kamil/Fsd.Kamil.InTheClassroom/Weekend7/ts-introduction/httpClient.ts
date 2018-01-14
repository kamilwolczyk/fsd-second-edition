import { Question } from "./quiz";

export class HttpClient {
    static getFromServer(url: string):Promise<Array<Question>> {
        const promise:Promise<Array<Question>> = new Promise(() => {
            return [
                new Question(),
                new Question(),
                new Question(),
            ];
        });

        return promise;
    }
}