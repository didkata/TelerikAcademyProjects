using System;

class PrintSequenceOfNums
{
    static void Main()
    {
        Console.Write("Enter number interval:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("All numbers in the interval [1..{0}]", n);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

