using System;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            // przypisanie do zmiennej

            Console.WriteLine("Podaj ocenę:");
            var rating = Console.ReadKey();

            // warunek, który zamienia ocenę na opis

            switch (rating.KeyChar)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine("Niedostateczny");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("Dopuszczający");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine("Dostateczny");
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine("Dobry");
                    break;
                case '5':
                    Console.WriteLine();
                    Console.WriteLine("Bardzo dobry");
                    break;
                case '6':
                    Console.WriteLine();
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Ocena poza zakresem");
                    break;
            }
        }
    }
}
