/*Create a console application "SwapNumbers".
* Input 2 numbers from the console and then swap the values of the variables 
* so that the first variable has the second value and the second variable the first value.
* Please find examples below:
///
* Test Data:
* Input the First Number: 5
* Input the Second Number: 8
* Expected Output:
* After Swapping:
* First Number: 8
* Second Number: 5*/


Console.WriteLine("====================================================");

Console.WriteLine("===== 'Enter the first number' =====");
String inputOne = Console.ReadLine(); //nema potreba da se parsira za zadacava!
Console.WriteLine(" The first value from the input is " + inputOne);

Console.WriteLine("====================================================");
Console.WriteLine("===== 'Enter the second number' =====");
String inputTwo = Console.ReadLine();
Console.WriteLine(" the second value from the input is " + inputTwo);

string empty ;

Console.WriteLine("====================================================");
Console.WriteLine("Press enter to swap the values ");
Console.ReadLine();

// empty ja dobiva vrednosta na inputOne
empty = inputOne;
// inputOne ja dobivra vrednosta na inputTwo
inputOne = inputTwo;
// inputTwo ja zema vrednosta na inputOne koja sto veke ja prefrlivme pogore vo empty
inputTwo = empty;

Console.WriteLine("From the first input new value is " + inputOne);
Console.WriteLine("From the second input new value is " + inputTwo);


