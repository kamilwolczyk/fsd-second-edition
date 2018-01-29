using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Kamil.Cs.Ex2_3.Animals;
using Fsd.Kamil.Cs.Ex2_3.ProductMagazine;

namespace Fsd.Kamil.Cs.Ex2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char _choice;

            TextWriter write = new TextWriter();
           
            write.ChooseExNumber();

            if (write.ExNumber == "2")
            {
                //Ex2
                try
                {
                    write.StartTextAnimals("2");

                    Dog dog = new Dog("", 0);
                    Fox fox = new Fox("", 0);
                    Horse horse = new Horse("", 0);
                    Pig pig = new Pig("", 0);

                    write.InsertTex("dogs");
                    dog.NewDog();

                    write.InsertTex("foxes");
                    fox.NewFox();

                    write.InsertTex("horses");
                    horse.NewHorse();

                    write.InsertTex("pigs");
                    pig.NewPig();

                    Console.WriteLine();
                    dog.DogDisplay();
                    fox.FoxDisplay();
                    horse.HorseDisplay();
                    pig.PigDisplay();
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
            else
            {
                //Ex 3
                write.StartTextProducts("3");
                Menu menu = new Menu();

                try
                {
                    Menu.StartMenu();

                    for (; ; )
                    {
                        do
                        {
                            _choice = (char)Console.Read();
                        } while (_choice == '\n' || _choice == '\r');

                        switch (_choice)
                        {
                            case '1':
                                menu.ProductsDetails();
                                menu.EndMenuBuy();
                                menu.ProductsDecision();
                                menu.EndMenuWarehouse();
                                break;
                            case '2':
                                menu.ProductsDetails();
                                menu.EndMenuWarehouse();
                                menu.LeaveOrNotDecision();
                                break;
                            case '3':
                                menu.NewProduct();
                                menu.EndMenuWarehouse();
                                menu.LeaveOrNotDecision();
                                break;
                            case '4':
                                Console.Clear(); Environment.Exit(0); break;
                            default: Console.Clear(); Menu.StartMenu(); break;
                        }
                    }
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
                    write.EndText();
                    Console.ReadKey();
                }
            }
        }
    }
}
