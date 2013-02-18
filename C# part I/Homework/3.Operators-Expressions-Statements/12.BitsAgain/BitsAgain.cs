using System;

class BitsAgain
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Set Position of the bit: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value v:");
        int v = int.Parse(Console.ReadLine());
        int mask = (1 << p);
        if ((n & mask) == 0)
        {
            n = n | (1 << p);
            Console.WriteLine(n);
        }
        else if ((n & mask) != 0)
        {
            n = n & (~(1 << p));
            Console.WriteLine(n);

        }
    }
}

