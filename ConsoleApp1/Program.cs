namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
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
