using System.Linq;

namespace Lab2.Models
{
    internal class Sumator
    {
        public int[] Numbers { get; set; } = new int[] { 10, 20, 30};

        public int Sum() { return Numbers.Sum(); }
        public double SumDiv3() { return Numbers.Where(x => x % 3 == 0).Sum(); }

        public int Count() { return Numbers.Count(); }
        public void Display(int low, int high)
        {
            if (low < 0)
                low = 0;
            if (high > Numbers.Length - 1)
                high = Numbers.Length - 1;

            for (int i = low; i <= high; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
        }
    }
}
}
