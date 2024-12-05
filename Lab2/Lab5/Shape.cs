namespace Lab2.Lab5
{
    public abstract class Shape
    {
        public abstract double CalulateArea();
        public double CalulateArea2()
        {
            return 0;
        }
    }

    public class Square : Shape
    {
        public double X { get; set; }

        public override double CalulateArea()
        {
            if (X < 0)
            {
                throw new Exception(); //wywołanie wyjątku
            }
            return X * X;
        }
    }
}
