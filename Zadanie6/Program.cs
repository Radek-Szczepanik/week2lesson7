using System;
using System.Threading;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennej

            int height;

            // deklaracja i przypisanie do zmiennej

            string little = "Jesteś malutki";
            string small = "Jesteś krasnoludem";
            string medium = "Jesteś niski";
            string normal = "Masz przeciętny wzrost";
            string tall = "Jesteś wysoki";
            string big = "Jesteś bardzo wysoki";

            // przypisanie do zmiennej "height"

            for (; ; )
            {
                Console.WriteLine("Podaj swój wzrost:");
                string Height = Console.ReadLine();
                int.TryParse(Height, out height);

                // warunek, który przypisuje kategorię do wzrostu

                if (height >= 140 && height < 150)
                {
                    Console.WriteLine(small);
                }
                else if (height >= 150 && height < 165)
                {
                    Console.WriteLine(medium);
                }
                else if (height >= 165 && height < 175)
                {
                    Console.WriteLine(normal);
                }
                else if (height >= 175 && height < 190)
                {
                    Console.WriteLine(tall);
                }
                else if (height >= 190)
                {
                    Console.WriteLine(big);
                }
                else
                {
                    Console.WriteLine(little);
                }

                Console.WriteLine();
            }
        }
    }
}
