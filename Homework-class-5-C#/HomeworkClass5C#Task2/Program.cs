//Take a sentence as input and print its words.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

Console.WriteLine("Enter a sentence");
string Inputsentence = Console.ReadLine();

string[] words = Inputsentence.Split(' ');

Console.WriteLine("The words in the sentence are");
foreach (string word in words)
{
    Console.WriteLine(word);
}
/////////////////////////bonus ///////
///
Console.WriteLine("please answer the following questions. Press enter ...");
Console.WriteLine("What is your name ");
string Name = Console.ReadLine();
Console.WriteLine($"{Name} please enter yuor lastname");
string LastName = Console.ReadLine();
Console.WriteLine($"Mr/Mrs {LastName} Please Entre yuor age ");
int Age = Convert.ToInt32(Console.ReadLine());

int yearofBornIs = 2023 - Age;

Console.WriteLine($"Mr/Mrs {Name} {LastName} You are bori in {yearofBornIs}");

string[] nameIs = Name.Split(" ");
foreach (string name in nameIs)
{
   Console.WriteLine(name);
}
string[] lastn = LastName.Split(" ");
foreach (string last in lastn)
{
    Console.WriteLine(last);
}
string born = yearofBornIs.ToString();
foreach (char ch in born)
{
    Console.WriteLine(ch);
}




