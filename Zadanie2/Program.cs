using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennej

            int liczba;

            // przypisanie do zmiennej

            for(; ; )
            {
                Console.WriteLine("Podaj liczbę:");
                string Liczba = Console.ReadLine();
                int.TryParse(Liczba, out liczba);

                // warunek, który sprawdza czy liczba jest parzysta czy nie

                if (liczba % 2 == 0)
                {
                    Console.WriteLine($"{liczba} jest liczbą parzystą");
                }
                else
                {
                    Console.WriteLine($"{liczba} jest liczbą nieparzystą");
                }

                Console.WriteLine();
            }
        }
    }
}
