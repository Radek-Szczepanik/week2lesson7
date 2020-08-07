using System;

namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            // przypisanie do zmiennej

            Console.WriteLine("Podaj numer dnia:");
            var numberOfDay = Console.ReadKey();

            // warunek, który wyświetla dzień tygodnia po wpisaniu jego numeru

            switch (numberOfDay.KeyChar)
            {
                case '1':
                    Console.WriteLine();
                    Console.WriteLine("Poniedziałek");
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("Wtorek");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine("Środa");
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine("Czwartek");
                    break;
                case '5':
                    Console.WriteLine();
                    Console.WriteLine("Piątek");
                    break;
                case '6':
                    Console.WriteLine();
                    Console.WriteLine("Sobota");
                    break;
                case '7':
                    Console.WriteLine();
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Nie ma takiego dnia w tygodniu");
                    break;
            }
        }
    }
}
