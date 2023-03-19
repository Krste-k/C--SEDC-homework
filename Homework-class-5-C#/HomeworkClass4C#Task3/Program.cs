//Create a function that takes a number as input. This method should return the sum of the digits in the number.

Console.WriteLine("Input a number");
int Inputnumber = Convert.ToInt32(Console.ReadLine());
int ReturnSum(int x)
{

    int Sum = 0;
    while (x != 0)
    {
        int Dig = x % 10;
        Sum += Dig;
        x /= 10;
    }
    return Sum;
}

int Result = ReturnSum(Inputnumber);
Console.WriteLine(Result);

