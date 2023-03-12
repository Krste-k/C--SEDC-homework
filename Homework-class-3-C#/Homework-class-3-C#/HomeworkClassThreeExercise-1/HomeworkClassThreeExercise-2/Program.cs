/*Make a console application called SumOfEven. Inside it create an array of 6 integers.
 * Get numbers from the input, find and print the sum of the even numbers from the array:
*/

int[] ArrOfnum = new int[6];
Console.WriteLine("Enter 6 numbers ");
for (int i = 0; i < 6; i++)
{
    ArrOfnum[i] = int.Parse(Console.ReadLine());
}

int sumOfEven = 0;
foreach (int num in ArrOfnum)
{
    if (num % 2 == 0)
    {
        sumOfEven += num; 

        
        if (sumOfEven <= 20)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        else if (sumOfEven > 20)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        else if (sumOfEven >= 40)
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else if (sumOfEven >= 60)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
        else if (sumOfEven >= 80)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }
        Console.ForegroundColor = ConsoleColor.Black;
    }
    
       
}


Console.WriteLine("The sum of even numbers is: " + sumOfEven);