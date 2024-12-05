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

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
