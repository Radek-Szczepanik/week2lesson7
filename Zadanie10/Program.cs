using System;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennych

            int sideA, sideB, sideC;

            // przypisanie do zmiennych

            for(; ; )
            {
                Console.WriteLine("Podaj długość boku a:");
                string A = Console.ReadLine();
                int.TryParse(A, out sideA);

                Console.WriteLine();

                Console.WriteLine("Podaj długość boku b:");
                string B = Console.ReadLine();
                int.TryParse(B, out sideB);

                Console.WriteLine();

                Console.WriteLine("Podaj długość boku c:");
                string C = Console.ReadLine();
                int.TryParse(C, out sideC);

                Console.WriteLine();

                // warunek, który sprawdza czy można zbudować trójkąt

                if (sideA > 0 && sideB > 0 && sideC > 0 && sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                {
                    Console.WriteLine("Można zbudować trójkąt");
                }
                else
                {
                    Console.WriteLine("Nie można zbudować trójkąta");
                }

                Console.WriteLine();
            }
        }
    }
}
