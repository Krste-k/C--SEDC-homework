// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bank acount");
Console.WriteLine("The pasword is 123");
Console.WriteLine(" Еnter your name ( Marko)");

string input = Console.ReadLine();
if (input == "Marko")
{
    Console.WriteLine("Valid name");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("invalid name");
}

Console.WriteLine(" Еnter the pasword ");
string input1 = Console.ReadLine();
if (input1 == "123")
{
    Console.WriteLine("Pasword is true press enter to ...");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Pasword is wrong!");
}

Console.ReadLine();
Console.WriteLine("- Pres 1 to see status on Yuor bank acount \n- Press 2 to withdraw money \n- Press 3 to place money ");
string input2 = Console.ReadLine();
int myMoney = 50000;

if (input2 == "1") 
{
    Console.WriteLine("On your account you have " + myMoney + " $.");
}


if (input2 == "2")
{
    Console.WriteLine("Тype the withdrawal amount");
    int input3_1 = int.Parse(Console.ReadLine());

    int newBalance = myMoney - input3_1;
    Console.WriteLine("new balance on yuor acount is " + newBalance + "$");
    if (newBalance > myMoney)
    {
        Console.WriteLine("the amount is greater than" + myMoney + "$");
    }
}
if (input2 == "3")
{
    Console.WriteLine("Еnter the amoun");
    int input3_2 = int.Parse(Console.ReadLine());
    int placeMoney = myMoney + input3_2;
    Console.WriteLine("new balance on yuor acount is " + placeMoney + "$" );
    if (input3_2 > 10000)
    {
        Console.WriteLine("The origin of money :D ");
    }
    else
    {
        Console.WriteLine("for an amount up to 10000 there is no need for the origin of the money");

    }

}
