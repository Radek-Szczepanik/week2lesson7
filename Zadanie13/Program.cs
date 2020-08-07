using System;

namespace Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennych

            int digit1, digit2;

            // przypisanie do zmiennych

            Console.WriteLine("Podaj pierwszą liczbę:");
            string D1 = Console.ReadLine();
            int.TryParse(D1, out digit1);

            Console.WriteLine();

            Console.WriteLine("Podaj drugą liczbę:");
            string D2 = Console.ReadLine();
            int.TryParse(D2, out digit2);

            Console.WriteLine();

            // utworzenie menu

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            Console.WriteLine();

            

            // warunek, który wybiera opcję z menu i wykonuje działanie

            var choice = Console.ReadKey();
            switch (choice.KeyChar)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine($"Twój wynik to:\n{digit1 + digit2}");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine($"Twój wynik to:\n{digit1 - digit2}");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine($"Twój wynik to:\n{digit1 * digit2}");
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine($"Twój wynik to:\n{digit1 / digit2}");
                    break;
            }
        }
    }
}
