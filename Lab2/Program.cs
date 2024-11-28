/*// See https://aka.ms/new-console-template for more information
using Lab2.Models;

Console.WriteLine("Hello, World!");

Person o = new Person("Testy");

var o2 = new Person("TS") {
Age = 30
};

//o2.Age = 30;

o.Welcome();

var sum = new Sumator();

Console.WriteLine(sum.Count());
Console.WriteLine(sum.SumDiv3());
Console.WriteLine(sum.Sum());
sum.Display(1, 2);*/

using Lab2.Models;

Shape rec = new Rectangle();
var rec2 = new Rectangle();


var shapes = new List<Shape>()
{
    rec,
    rec2,
    new Shape()
};

foreach (var shape in shapes)
{
    shape.Draw();
}