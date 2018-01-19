import { Drink } from "../models/products/drink/drink";
import { MainCourse } from "../models/products/main-course/main-course";

export class MockProductData {
    drinks: Array<Drink>;
    meals: Array<MainCourse>;

    constructor() {
        this.drinks = [
            new Drink('Mojito', 'pół limonki, 2 łyżeczki cukru, mięta 40 ml, białego rumu, kruszony lód, woda gazowana', 12.50),
            new Drink('Margarita', '40 ml tequili, 20 ml likieru Triple Sec, 15 ml soku z cytryny', '13.20'),
            new Drink('Daiquiri', '40 ml białego rumu, 20 ml soku z limonki, 5 ml syropu cukrowego, kostki lodu, plasterek limonki', 14.00),
            new Drink('Sex on the beach', 'kilka kostek lodu, 20 ml wódki, 20 ml likieru brzoskwiniowego, 100 ml soku żurawinowego, 100 ml soku pomarańczowego', 11.20),
            new Drink('Pina Colada', '40 ml rumu, 40 ml mleczka kokosowego, 5 plastrów ananasa z puszki, kruszony lód', 8.20),
            new Drink('Kamikaze', '50 ml wódki, 50 ml Blue curacao, 50 ml soku z cytryny', 6.5),
        ];

        this.meals = [
            new MainCourse('Rolada wieprzowa', 'kluski, sałatka z czerwonej kapusty', 27.00),
            new MainCourse('Kotlet schabowy panierowany', 'frytki, zestaw surówek', 26.00),
            new MainCourse('Polędwiczka po belwedersku', 'surówka z kapusty białej, pieczywo', 28.00),
            new MainCourse('Kotlet po żydowsku', 'surówka z kapusty białej, ziemniaki', 26.00),
            new MainCourse('Stek z polędwicy wieprzowej z masłem czosnkowym', 'frytki, surówka z kapusty białej', 33.00),
        ];
    }
}
