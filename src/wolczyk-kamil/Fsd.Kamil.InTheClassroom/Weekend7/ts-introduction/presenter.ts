export class Presenter {
    constructor(private text: string, private time: number) { }

    start(dupa: Function): void {
        setTimeout(() => {
            dupa(this.text);
        }, this.time);
    }
}