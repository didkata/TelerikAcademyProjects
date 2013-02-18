using System;

class PrintsNumToN
{
    static void Main()
    {
        Console.WriteLine("Enter number for n:");
        int n = int.Parse(Console.ReadLine());
        int num=1;

        while (num <= n)
        {
            Console.WriteLine(num);
            num++;
        } 
    }
}
