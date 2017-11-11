using System;
using Weekend2.Domain.Work;
using Weekend2.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Weekend2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarOld audi = new CarOld("Audi A2");
            Classroom salaVpietro = new Classroom();

            ComfortManager(audi);
            ComfortManager(salaVpietro);

            ConsolePresenter.Pause();
        }

        public static void ComfortManager(IClimatronic climatronicObject)
        {
            climatronicObject.ClimatronicOn();
        }

        public static void Console()
        {
            ConsolePresenter presenter = new ConsolePresenter();
            presenter.Introduction(2);
            presenter.Footer();
        }

        public static void Gta()
        {
            Game gta = new Game();
            gta.RunGame();
        }

        public static void CarBase()
        {
            CarOld audi = new CarOld("Audi", "A4", 4);
            CarOld bmw = new CarOld("Bmw", "Seria 5", 5);
            CarOld renault = new CarOld("Renault Megane");
        }

        public static void People()
        {
            try
            {
                Person[] people = new Person[]
                {
                    new Person("Jan", "Kowalski", 76),
                    new Person("Robert", "Lewandowski", 28),
                    new Person("Adam", "Małysz", 39),
                    new Boss("Mieszko", "Pierwszy", 60, 10500),
                    new Employee("Krzysztof", "Krawczyk", 76, 1800),
                    new Employee("Zosia", "Samosia", 28, 7521)
                };

                List<Person> list = new List<Person>();

                //.....

                //for(int i = 0; i < list.Count; i++)
                //{
                //    Person person = list.ElementAt(i);

                //    if(person.FirstName[0] == 'K')
                //        list.Remove(person);
                //}

                foreach (var person in list)
                    System.Console.WriteLine(person.SayHello());

                foreach (var person in people)
                    System.Console.WriteLine(person.SayHello());
            }
            catch (InvalidOperationException exception)
            {
                System.Console.WriteLine("Brak pamięci");
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            finally
            {
                System.Console.ReadKey();
            }
        }
    }
}
