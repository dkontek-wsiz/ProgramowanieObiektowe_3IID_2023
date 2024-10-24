namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Console.WriteLine("Podaj liczbę");
                        var input = Console.ReadLine();

                        Console.WriteLine(IsEven(int.Parse(input)) ? "Parzysta" : "Nieparzysta");
                       */

            while (true)
            {
                Console.WriteLine("Wybierz opcję");
                Console.WriteLine("1. Czy Parzysta");
                Console.WriteLine("2. Wypisz Parzyste");
                Console.WriteLine("3. Silnia");
                Console.WriteLine("0. Wyjście");

                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        {
                            CheckEven();
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Podaj liczbe");
                            var x = int.Parse(Console.ReadLine());
                            Console.WriteLine(Silnia(x));
                            break;
                        }
                }

                if (input == 0) break;
            }
        }


        static int Silnia(int x)
        {
            if (x == 0) return 1;

            return Silnia(x - 1) * x;
        }

        static void CheckEven()
        {
            Console.WriteLine("Podaj liczbę");
            var input = Console.ReadLine();

            Console.WriteLine(IsEven(int.Parse(input)) ? "Parzysta" : "Nieparzysta");
        }


        static bool IsEven(int input)
        {
            return input % 2 == 0;
        }


    }
}
