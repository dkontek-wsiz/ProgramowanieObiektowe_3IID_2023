// See https://aka.ms/new-console-template for more information
using Lab2.Models;

Console.WriteLine("Hello, World!");

Person o = new Person("Testy");

var o2 = new Person("TS") {
Age = 30
};

//o2.Age = 30;

o.Welcome();