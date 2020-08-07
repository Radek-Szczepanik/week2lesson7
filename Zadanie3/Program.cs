using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennej

            int liczba;

            // przypisanie do zmiennej

            for (; ; )
            {
                Console.WriteLine("Podaj liczbę:");
                string Liczba = Console.ReadLine();
                int.TryParse(Liczba, out liczba);

                // warunek, który sprawdza czy liczba jest dodatnia czy ujemna

                if (liczba < 0)
                {
                    Console.WriteLine($"{liczba} jest liczbą ujemną");
                }
                else
                {
                    Console.WriteLine($"{liczba} jest liczbą dodatnią");
                }
               
                Console.WriteLine();
            }
        }
    }
}
