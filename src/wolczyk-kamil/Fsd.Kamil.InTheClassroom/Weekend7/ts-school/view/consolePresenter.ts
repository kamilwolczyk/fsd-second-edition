import { IPresentable } from "./presentable";

export class ConsolePresenter {
    static display(items: Array<IPresentable>): void {
        items.forEach(item => {
            console.log(item);
        });
    }
}