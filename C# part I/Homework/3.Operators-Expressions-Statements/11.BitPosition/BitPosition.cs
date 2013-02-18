using System;

class BitPosition
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Set Position of the bit: ");
        int b = int.Parse(Console.ReadLine());
        int i = 1;
        int mask = i << b;
        int result = num + mask;
        Console.WriteLine(result != 0 ? 1 : 0);

    }
}