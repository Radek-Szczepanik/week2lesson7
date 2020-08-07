using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracja zmiennej

            int age;

            // przypisanie do zmiennej

            for(; ; )
            {
                Console.WriteLine("Podaj swój wiek:");
                string Age = Console.ReadLine();
                int.TryParse(Age, out age);

                // warunek, który sprawdza stanowisko uzależnione od wieku

                if (age >= 21 && age < 30)
                {
                    Console.WriteLine("Możesz zostać posłem lub premierem");
                }
                else if (age >= 21 && age >= 30 && age < 35)
                {
                    Console.WriteLine("Możesz zostać posłem, senatorem lub premierem");
                }
                else if (age >= 21 && age >= 30 && age >= 35)
                {
                    Console.WriteLine("Możesz zostać posłem, senatorem, premierem lub prezydentem");
                }
                else
                {
                    Console.WriteLine("Niestety, musisz zdobyć wiedzę i doświadczenie");
                }

                Console.WriteLine();
            }
        }       
    }
}
