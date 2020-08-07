using System;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennych

            int maths;
            int physics;
            int chemistry;
            
            // przypisanie do zmiennych

            for(; ; )
            {
                Console.WriteLine("Podaj wynik z matematyki:");
                string Maths = Console.ReadLine();
                int.TryParse(Maths, out maths);

                Console.WriteLine();

                Console.WriteLine("Podaj wynik z fizyki:");
                string Physics = Console.ReadLine();
                int.TryParse(Physics, out physics);

                Console.WriteLine();

                Console.WriteLine("Podaj wynik z chemii:");
                string Chemistry = Console.ReadLine();
                int.TryParse(Chemistry, out chemistry);

                Console.WriteLine();

                // warunek, który sprawdza dopuszczenie do rekrutacji

                if ((maths + physics + chemistry) > 180)
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
                }
                else if ((maths + physics) > 150 || (maths + chemistry) > 150)
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
                }
                else
                {
                    Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
                }

                Console.WriteLine();
            } 
        }
    }
}
