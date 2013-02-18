using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("enter number for n >=0");
        int n = int.Parse(Console.ReadLine());
        decimal multiplication;
        decimal sum;
        BigInteger factorialMultip = 1;
        BigInteger factorialSum = 1;
        BigInteger factorialN = 1;
        BigInteger catalanNumber;

        if (n >= 0)
        {
           multiplication = (2 * n);
           sum = (n + 1);

           for (int i = 1; i <= multiplication; i++)
           {
               factorialMultip *= i;                 
           }
           for (int i = 1; i <= sum; i++)
           {
               factorialSum *= i;
           }
           for (int i = 1; i <= n; i++)
           {
               factorialN *= i;
           }

           catalanNumber = factorialMultip / (factorialSum * factorialN);
           Console.WriteLine("Catalan Number is:{0}",catalanNumber);
        }
        else Console.WriteLine("Try again!!! n >=0");
    }
}