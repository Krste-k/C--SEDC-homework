// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine(" C# Homework clas two");

Console.WriteLine("Hello this is an aplication that calculate two numbers.Press enter to start");
Console.ReadLine();

Console.WriteLine("Еnter the first number ");
var  input1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("еnter an operator + - / *");
var operatorInput = Console.ReadLine();

Console.WriteLine("Еnter the second number ");
var input2 = Convert.ToInt32(Console.ReadLine());

if (operatorInput == "+" )
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The result of " + input1 + " + " + input2 + " = " + (input1+input2 ) + " ." );
    Console.WriteLine(input1 + input2);

}else if (operatorInput == "-")
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    int  ResultOfMinus = input1 - input2;
    Console.WriteLine("The result of " + input1 + " - " + input2 + " = " + ResultOfMinus + " .");
    Console.WriteLine(input1 - input2);

}else if(operatorInput == "*")
{
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.White;
    int ResultOfMultip = input1 * input2;
    Console.WriteLine("The result of " + input1 + " * " + input2 + " = " + ResultOfMultip + " .");
    Console.WriteLine(input1 * input2);

}else if (operatorInput == "/")
{
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.ForegroundColor = ConsoleColor.Magenta;
    int ResultOfDivision = input1 / input2;
    Console.WriteLine("The result of " + input1 + " / " + input2 + " = " + ResultOfDivision + " .");
    Console.WriteLine(input1 / input2);

}
else
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("You have entered an invalid character This application only works with numbers and mathematical operators");
}


