/*Make a new console application called StudentGroup
Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
Get a number from the console between 1 and 2 and print the students from that group in the console.
Ex: studentsG1 ["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
*/

Console.WriteLine("Enter 1 or 2");
int input = int.Parse(Console.ReadLine()); 
string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Leo", "Marko", "Ivo", "Petre", "Stojce" };

if (input == 1)
{
    Console.WriteLine("Studetns from G1 : ");
    foreach (string student in studentsG1)
    Console.WriteLine(student);
} else if (input == 2)
{
    Console.WriteLine("Studetns from G2 : ");
    foreach (string student in studentsG2)
    Console.WriteLine("studetns from G1 :" + student);

}
