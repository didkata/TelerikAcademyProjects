using System;

class SumOfNumbers
{
    static void Main()
    {
           
        Console.Write("Enter number for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number for X: ");
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        int degree=1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
                degree *= x;
            }
            sum += (double)(factorial) / (double)(degree);
        }
        Console.WriteLine("The sum of S = 1 + 1!/X + 2!/X^2 + … + N!/X^N is {0}", sum);
    }
}
