using System;
using System.Numerics;

class NFactoriel
{
    static void Factorial(int i)
    {
        int n = i;
        BigInteger factorial = 1;
        do
        {
            factorial = factorial * n;
            n--;
        }
        while (n > 0 );
        Console.WriteLine("{0}! = " + factorial,i);
    }

    static void Main()
    { 
        for (int i = 0; i <=100; i++)
        {         
            Factorial(i);
        }
    }
}

