using Lab2.Interfaces;

namespace Lab2.Lab6
{
    public class Person : IEntity<int>, ICreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
