using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weekend2.Domain;

namespace Weekend2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car audi = new Car("Audi", "A4", 4);
                Car bmw = new Car("Bmw", "Seria 5", 5);
                Car renault = new Car("Renault Megane");

                Person[] people = new Person[]
                {
                    new Person("Jan", "Kowalski", 76),
                    new Person("Robert", "Lewandowski", 28),
                    new Person("Adam", "Małysz", 39),
                    new Boss("Mieszko", "Pierwszy", 60, 10500),
                    new Employee("Krzysztof", "Krawczyk", 76, 1800),
                    new Employee("Zosia", "Samosia", 28, 7521)
                };

                foreach (var person in people)
                    Console.WriteLine(person.SayHello());
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Brak pamięci");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }

        
    }
}
