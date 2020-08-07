using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennych

            int a;
            int b;

            // przypisanie do zmiennych

            Console.WriteLine("Podaj wartość zmiennej a:");
            string var1 = Console.ReadLine();
            int.TryParse(var1, out a);

            Console.WriteLine("Podaj wartość zmiennej b:");
            string var2 = Console.ReadLine();
            int.TryParse(var2, out b);

            // warunek, który sprawdza czy zmienne są równe czy nie

            if (a == b)
            {
                Console.WriteLine($"Zmienne {a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"Zmienne {a} i {b} są nierówne");
            }
        }
    }
}
