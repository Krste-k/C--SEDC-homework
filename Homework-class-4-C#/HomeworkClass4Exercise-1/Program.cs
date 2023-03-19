//Make the calculator with switch. Additional: Check divide by zero.

Console.WriteLine("Enter number");
int InputNumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the operator +, -, *, /");
char InputOperand = char.Parse(Console.ReadLine());

Console.WriteLine("Enter number ");
int InputNumberTwo = Convert.ToInt32(Console.ReadLine());
int Calculator( int x, char operations, int y)
{
    int result = 0;
   
    switch (operations)
    {
        case '+':
            result = x + y;
            break;
        case '-':
            result = x - y;
            break;
        case '*':
            result = x * y;
            if (y == 0)
            {
                string byZero = $"Error multiplication by 0 !";
                Console.WriteLine(byZero);
            }
            break;
        case '/':
            result = x / y;
            if (y == 0)
            {
                string byZero = $"Error division by 0 !";
                Console.WriteLine(byZero);
            }
            break;
        default:
            Console.Error.WriteLine("Invalid operator!");
            break;
    }
  
    return result;
  
}



int result = Calculator(InputNumberOne, InputOperand, InputNumberTwo);

Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine($"{InputNumberOne} {InputOperand} {InputNumberTwo} = {result}");
Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine(result);

