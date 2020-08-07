using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennej

            int year;

            // przypisanie do zmiennej

            for(; ; )
            {
                Console.WriteLine("Podaj rok:");
                string Year = Console.ReadLine();
                int.TryParse(Year, out year);

                // warunek, który sprawdza czy rok jest przestępny

                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine($"rok {year} jest przestępny");
                }
                else
                {
                    Console.WriteLine($"rok {year} nie jest przestępny");
                }

                Console.WriteLine();
            }
        }
    }
}
