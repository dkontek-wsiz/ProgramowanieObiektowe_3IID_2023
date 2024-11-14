namespace Lab2.Models
{
    public class Licz(double val)
    {
        private double value = val;

     /*   public Licz(double val)
        {
            value = val;
        }*/

        public void Add(double value)
        {
            this.value += value;
        }

        public void DisplayValue()
        {
            Console.WriteLine(value);
        }
    }
}