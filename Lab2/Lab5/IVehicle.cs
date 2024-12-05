namespace Lab2.Lab5
{
    public interface IVehicle
    {
        int MaxSpeed { get; set; }

        void Start()
        {
            Console.WriteLine("Start");
        }

        void Stop();
    }

    public class Car : IVehicle
    {
        public int MaxSpeed { get; set; }

        public void Start() 
        {
            Console.WriteLine("Start engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop engine");
        }
    }

    public class Bike : IVehicle
    {
        public int MaxSpeed { get; set; }

        public void IncreaseSpeed()
        {

        }

        public void Start()
        {
            Console.WriteLine("Start ride");
        }

        public void Stop()
        {
            Console.WriteLine("Stop ride");
        }
    }
}
