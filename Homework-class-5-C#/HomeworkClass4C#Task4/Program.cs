/*Make a method called AgeCalculator
* The method will have one input parameter, your birthday date
* The method should return your age
* Show the age of a user after he inputs a date
* Note: take into consideration if the birthday is today, after or before today*/

Console.WriteLine("Enter yuor birday 'dd','mm','yyyy'");
DateTime input = Convert.ToDateTime(Console.ReadLine());


int AgeCalculator(DateTime input)
{
    DateTime today = DateTime.Today;
    int age = today.Year - input.Year;
    if (input > today.AddYears(-age))
    {
        age--;
    }
    return age;
}

int NewCalc = AgeCalculator(input);
Console.WriteLine(NewCalc);


