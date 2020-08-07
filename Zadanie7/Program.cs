using System;
using System.Linq;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja pustej tablicy

            int[] digits = new int[3];

            // deklaracja zmiennej

            int digit;

            for(; ; )
            {
                Console.WriteLine("Podaj 3 liczby:");
            
                // pętla, która dodaje do tablicy liczby podane przez użytkownika

                for (int i = 0; i < 3; i++)
                {
                    string Digit = Console.ReadLine();
                    int.TryParse(Digit, out digit);
                    digits[i] = + digit;
                }

                Console.WriteLine();

                int biggestNumber = digits.Max();
                Console.WriteLine($"{biggestNumber} to największa liczba");

                Console.WriteLine();
            }
        }
    }
}
