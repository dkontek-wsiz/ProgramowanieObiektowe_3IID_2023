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
/*
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
}*/


/*using Lab2.Lab5;

//Obsługa wyjątku
try
{

    Shape shape = new Square() { X = 5 };

    shape.CalulateArea();
}
catch (NotImplementedException ex) //"Łapanie" wyjątków not implemented
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex) //"Łapanie" wyjątków
{
    Console.WriteLine(ex.Message);
}*/


using Lab2.Interfaces;
using Lab2.Lab6;

/*var list = new List<int>() { 0, 1, 1 };

Console.WriteLine(list.Any(x => x > 0)); // true jesli dowolny element jest wiekszy od 0
Console.WriteLine(list.All(x => x > 0)); // true jesli wszystkie elementy są wieksze od 0
list.AddRange([10, 11]); // dodanie do listy liczb 10, 11
var listof1 = list.Where(x => x == 1); //Ograniczenie listy tylko do elementów równych 1
Console.WriteLine(list.Count()); // zliczenie elementów
var arr = list.Distinct().ToArray(); // lista bez duplikatów
Console.WriteLine(list.Contains(1)); // true jeśli lista zawiera 1
Console.WriteLine(list.FirstOrDefault(x => x == 1)); // pierwszy element listy równy 1 lub null
Console.WriteLine(list.First(x => x == 1)); // pierwszy element listy równy 1 lub błąd
Console.WriteLine(list.Last()); //ostani element listy
Console.WriteLine(list.Count());

list.Min();
list.Max();
list.Sum();*/

IBookRepository repository = new BookRepository();
var personRepoistory = new PersonRepository();

foreach (var item in repository.GetAll())
{
    Console.WriteLine(item.Title);
}

var book = repository.Get(1);

personRepoistory.Create(new Person()
{
    Id = 1,
    FirstName = "Test",
    LastName = "Test",
});

personRepoistory.BorrowBook(1, book);
personRepoistory.BorrowBook(1, book);

var person = personRepoistory.Get(1);
Console.WriteLine($"Książki wypożyczone przez {person.FirstName} {person.LastName}");
foreach (var item in personRepoistory.GetBorrowedBook(person.Id))
{ 
    Console.WriteLine(item.Title);
}
