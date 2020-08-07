using System;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennej

            int temp;

            // przypisanie do zmiennej

            for(; ; )
            {
                Console.WriteLine("Podaj temperaturę:");
                string Temp = Console.ReadLine();
                int.TryParse(Temp, out temp);

                // warunek, który zwraca nazwę w zależności od podanej temperatury

                if (temp < 0)
                {
                    Console.WriteLine("Cholernie piździ");
                }
                else if (temp >= 0 && temp < 10)
                {
                    Console.WriteLine("Zimno");
                }
                else if (temp >= 10 && temp < 20)
                {
                    Console.WriteLine("Chłodno");
                }
                else if (temp >= 20 && temp < 30)
                {
                    Console.WriteLine("W sam raz");
                }
                else if (temp >= 30 && temp < 40)
                {
                    Console.WriteLine("Zaczyna być słabo, bo gorąco");
                }
                else
                {
                    Console.WriteLine("A weź, wyprowadzam się na Alaskę");
                }

                Console.WriteLine();
            }
        }
    }
}
