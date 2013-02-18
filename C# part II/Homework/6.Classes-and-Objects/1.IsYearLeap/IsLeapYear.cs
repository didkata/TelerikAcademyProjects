using System;

class IsLeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter year (day and month) to check:");
        DateTime leapYear = DateTime.Parse(Console.ReadLine());

        int year = leapYear.Year;
        Console.WriteLine("Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));

    }
}

