using System;

class TheBiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers to find the biggest");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The biggest is {0}", a);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("The biggest is {0}", b);
            }
            else
                Console.WriteLine("The biggest is {0}", c);
        }
    }
}

