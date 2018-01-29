using System;

namespace Fsd.Kamil.Weekend1.Start
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonPresenter presenter = new PersonPresenter();
            presenter.Run();
            Console.ReadKey();
        }

        static int AddOne(int number)
        {
            number = number + 1;
            return number;
        }

        static int[] GetNumbers(int count)
        {
            Random rand = new Random();
            int[] tab = new int[count];

            for (int i = 0; i < count; i++)
                tab[i] = rand.Next(100);

            return tab;
        }

        static int GetNumber()
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }

        static void SumFunction()
        {
            const string endOfAction = "sumuj";
            int sum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == endOfAction)
                    break;

                var number = int.Parse(input);

                if (number % 2 != 0)
                    continue;

                sum += number;
            }

            Console.WriteLine($"Suma = {sum}");
        }

        void Conditions()
        {
            int a = 4;
            int b = 6;

            if (a > b)
                Console.WriteLine("Jest ok");
            else if (a == b)
                Console.WriteLine("Jest średnio");
            else
                Console.WriteLine("Jest dupa!");

            Console.WriteLine(a > b ? "Jest ok" : "Jest dupa!");

            switch (a)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("A jest równe 5");
                    Console.WriteLine("I jest fajnie");
                    break;
                case 6:
                    Console.WriteLine("A jest równe 6");
                    break;
                default:
                    Console.WriteLine("I nic sie nie stało");
                    break;
            }
        }

        void Operations()
        {
            float a = 3.14f;
            int b = 8;
            float c = 21.4f;
            float result = a * b;

            //Console.WriteLine((a + b).ToString());
            //Console.WriteLine(c - b);
            //Console.WriteLine(result);
            //Console.WriteLine(result + a);
            //Console.WriteLine(13 % 3);
        }

        void Strings()
        {
            string k = "Kamil";
            string w = "Wolczyk";

            Console.WriteLine(string.Format("Ja jestem {1} {0} {1} {1}", k, w));
            Console.WriteLine($"Ja jestem {k} {w} {2 + 6}");
            Console.WriteLine(@"\n");
        }

        void Variables()
        {
            bool z = true;
            bool z1 = false;

            short x1 = 2;
            int x = 4;
            long x2 = 8;

            float y = 4;
            double y1 = 8;
            decimal y2 = 4;

            double k = 32.200057921;
            int k1 = (int)32.200057921;
            string k2 = k.ToString();

            int a1 = 5;
            int a2 = 7;
            int a3 = 8;

            int[] tab = new int[3];
            int[] tab2 = { 5, 7, 8 };

            const decimal pi = (decimal)3.14;
        }
    }
}
