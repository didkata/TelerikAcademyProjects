using System;

class ReadIntNums
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:");
        int c = int.Parse(Console.ReadLine());
        int Sum = a + b + c;
        Console.WriteLine("The sum is:{0}",Sum );

    }
}
