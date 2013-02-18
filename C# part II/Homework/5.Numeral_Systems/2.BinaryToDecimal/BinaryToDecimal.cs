using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("enter binary number:");
        string  number=Console.ReadLine();
        int decimalNum=0;
        for (int i = 0; i < number.Length; i++)
        {

            if (number[number.Length-i-1]== '0')
            {
                continue;
            }
            decimalNum=decimalNum + (int)Math.Pow(2, i);
        }
        Console.WriteLine(decimalNum);
    }
}

