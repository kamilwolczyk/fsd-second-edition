using System;

namespace Fsd.Kamil.Weekend1.Start
{
    class PersonPresenter
    {
        private int whenIsOld = 70;

        public void Run()
        {
            string name = GetConsoleLine("Podaj imie");
            int year = int.Parse(GetConsoleLine("Podaj wiek"));
            Gender gender = StringToGender(GetConsoleLine("Podaj płeć [facet|kobieta]"));

            Console.WriteLine($"Cześć {name} jesteś {CreateDescription(year, gender)}");
        }

        private Gender StringToGender(string text)
        {
            return text == "facet" ? Gender.Male : Gender.Female;
        }

        private string GetConsoleLine(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        private string CreateDescription(int year, Gender sex)
        {
            return sex == Gender.Male ?
                (year >= whenIsOld ? "starym facetem" : "młodym facetem") :
                (year >= whenIsOld ? "starą babą" : "młodą kobietą");
        }
    }
}
