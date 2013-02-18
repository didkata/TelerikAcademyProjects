using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        int num = int.Parse(Console.ReadLine());

        string result=null;

        do
        {
             result=num % 2 + result;
            num = num / 2;
        
        }
        while (num != 0);

        Console.WriteLine(result);
    }
}

