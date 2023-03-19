//Take one string from the input and print its last 5 characters.
//
Console.WriteLine("Input a sentence to see last 5 characters. ");
string InputText = Console.ReadLine();
string substringexample = InputText.Substring(InputText.Length-6);
Console.WriteLine(substringexample);


