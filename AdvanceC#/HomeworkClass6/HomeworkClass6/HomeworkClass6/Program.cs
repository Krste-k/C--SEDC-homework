//Create a class Person and a class Dog. Each Person can have one or more dogs. Create properties according some of the requirements below. Create a static db, static lists of the two classes.

//Find and print all persons firstnames starting with 'B', ordered by Age - DESCENDING ORDER
//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
//Find and print all Emily`s dogs names older than 1 year
//Find and print Sara`s first dog
//Find and print all white dogs names from Marko, Emily, Sara and Krste, ordered by Name - ASCENDING ORDER



///
using HomeworkClass6.Entity;
#region DB
Db.Persons = new List<Person>
        {
            new Person { Id = 1, FirstName = "Marko",LastName = "Krstevski", Age = 30, Dogs = new List<Dog> {
            new Dog { Id = 1, Name = "Bak", Age = 4, Color = "Brown", OwnerId = 1 }, 
            new Dog { Id = 2, Name = "Sarko", Age = 2, Color = "White", OwnerId = 1 } } },

            new Person { Id = 2, FirstName = "Ramce",LastName = "Ramadani", Age = 25, Dogs = new List<Dog> {
            new Dog { Id = 3, Name = "Panco", Age = 5, Color = "Brown", OwnerId = 2 },
            new Dog { Id = 4, Name = "Goni", Age = 1, Color = "Black", OwnerId = 2 } } },


            new Person { Id = 3, FirstName = "Krste", LastName = "Krstevski",Age = 40, Dogs = new List<Dog> {
            new Dog { Id = 5, Name = "Ben", Age = 3, Color = "White", OwnerId = 3 } } },
           
            new Person { Id = 4, FirstName = "Emily",LastName = "Smith", Age = 35, Dogs = new List<Dog> { 
            new Dog { Id = 6, Name = "Roky", Age = 2, Color = "Brown", OwnerId = 4 },
            new Dog { Id = 7, Name = "Bela", Age = 4, Color = "White", OwnerId = 4 },
            new Dog { Id = 8, Name = "Caki", Age = 3, Color = "Brown", OwnerId = 4 } } },
           
            new Person { Id = 5, FirstName = "Bogdan",LastName = "Spasovski", Age = 29, Dogs = new List<Dog> {
            new Dog { Id = 9, Name = "Rex", Age = 6, Color = "White", OwnerId = 5 },
            new Dog { Id = 10, Name = "Bon", Age = 2, Color = "Black", OwnerId = 5 } } },
           
            new Person { Id = 6, FirstName = "Sara",LastName = "Petkovska", Age = 45, Dogs = new List<Dog> { 
            new Dog { Id = 11, Name = "Ahil", Age = 1, Color = "Brown", OwnerId = 6 },
            new Dog { Id = 12, Name = "Laki", Age = 3, Color = "Black", OwnerId = 6 } } },

            new Person { Id = 7, FirstName = "Bob",LastName = "Smith", Age = 35, Dogs = new List<Dog> {
            new Dog { Id = 13, Name = "Lea", Age = 5, Color = "Brown", OwnerId = 7 },
            new Dog { Id = 14, Name = "Roni", Age = 1, Color = "White", OwnerId = 7 },
            new Dog { Id = 15, Name = "Zak", Age = 6, Color = "Brown", OwnerId = 7 } } },

            new Person { Id = 8, FirstName = "Cristofer",LastName = "Smok", Age = 35, Dogs = new List<Dog> {
            new Dog { Id = 16, Name = "Lan", Age = 5, Color = "Brown", OwnerId = 8 },
            new Dog { Id = 17, Name = "Rok", Age = 1, Color = "White", OwnerId = 8 },
            new Dog { Id = 18, Name = "Zaf", Age = 6, Color = "White", OwnerId = 8 },
            new Dog { Id = 19, Name = "Ri", Age = 1, Color = "Black", OwnerId = 8 },
            new Dog { Id = 20, Name = "Beta", Age = 6, Color = "White", OwnerId = 8 },
            new Dog { Id = 21, Name = "Raf", Age = 10, Color = "White", OwnerId = 8 },
            new Dog { Id = 22, Name = "Zaf", Age = 7, Color = "Black", OwnerId = 8 }} },
};
#endregion

#region All persons firstnames starting with 'B' ordered by Age

IEnumerable<string> startWithB = Db.Persons
    .Where(p => p.FirstName.StartsWith("B"))
    .OrderByDescending(p => p.Age)
    .Select(p => p.FirstName);

Console.WriteLine("Persons firstnames starting with 'B', ordered by Age ");
foreach (string name in startWithB)
{
    Console.WriteLine(name);
}
Console.WriteLine();
/////////////////////////////////////////////////////
///
//IEnumerable<string> EndWithE = Db.Persons
//    .Where(p => p.FirstName.EndsWith("E"))
//    .OrderByDescending(p => p.Id)
//    .Select (p =>  p.FirstName);

//Console.WriteLine("Persons firstnames Ends with 'E', ordered by Age ");

//foreach (string name in EndWithE)
//{
//    Console.WriteLine(name);
//}
//Console.WriteLine();




#endregion

#region  All brown dogs names and ages older than 3 years, ordered by Age

IEnumerable<string> result2 = Db.Dogs
    .Where(d => d.Color == "White" && d.Age > 3)
    
    .OrderBy(d => d.Age)
    .Select(d => d.Name);

Console.WriteLine("White dogs names and ages older than 3 years, ordered by Age.");
foreach (string name in result2)
{
    Console.WriteLine(name);
}
Console.WriteLine();
#endregion

#region All persons with more than 2 dogs, ordered by Name 

IEnumerable<string> result3 = Db.Persons
    .Where(p => p.Dogs.Count > 2)
    .OrderByDescending(p => p.LastName)
    .Select(p => p.FirstName);

Console.WriteLine("Persons with more than 2 dogs, ordered by Name.");
foreach (string name in result3)
{
    Console.WriteLine(name);
}
Console.WriteLine();
#endregion

#region Find and print all Emily`s dogs names older than 1 year

IEnumerable<string> result4 = Db.Persons
    .Where(p => p.FirstName == "Emily")
    .SelectMany(p => p.Dogs)
    .Where(d => d.Age > 1)
    .Select(d => d.Name);

Console.WriteLine("Emily`s dogs names older than 1 year:");
foreach (string name in result4)
{
    Console.WriteLine(name);
}
Console.WriteLine();
#endregion

#region Print Sara first dog
// 
IEnumerable<string> result5 = Db.Persons
    .Where(p => p.FirstName == "Sara")
    .Select(p => p.Dogs.First()?.Name);

Console.WriteLine("Sara`s first dog:");
Console.WriteLine(result5.First());
Console.WriteLine();
#endregion

#region Find and print all white dogs names from Marko, Emily, Sara and Krste, ordered by Name

IEnumerable<string> result6 = Db.Persons
    .Where(p => new[] { "Marko", "Emily", "Sara", "Krste" }
    .Contains(p.FirstName))
    .SelectMany(p => p.Dogs)
    .Where(d => d.Color == "White")
    .OrderBy(d => d.Name)
    .Select(d => d.Name);

Console.WriteLine("White dogs names from Marko, Emily, Sara and Krste, ordered by Name");
foreach (string name in result6)
{
    Console.WriteLine(name);
}

Console.WriteLine();
#endregion