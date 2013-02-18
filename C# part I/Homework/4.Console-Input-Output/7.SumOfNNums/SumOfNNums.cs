using System;

class SumOfNNums
{
    static void Main()
    {
        Console.WriteLine("Enter how mach number you want to sum:");
        int n = int.Parse(Console.ReadLine());
        int sum=0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the numbers you want to sum:");
            int numbers = int.Parse(Console.ReadLine());
            sum += numbers;
            
        }
        Console.WriteLine("The sum of entered numbers is:{0}", sum);
    }
}
