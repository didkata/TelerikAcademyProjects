using System;
using System.Numerics;

class CalculatesNAndK
{
    static void Main()
    {
        Console.WriteLine("Enter number for K (1<N<K):");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number for N:");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialKN=1;
        BigInteger result;
        int subtraction;

         if (k > n)
        {
           subtraction = (k - n);
            while (true)
            {
                if (k >= 1)
                {
                    factorialK *= k;
                    k--;
                }
                else break;

                if (n >= 1)
                {
                    factorialN *= n;
                    n--;
                }
                if(subtraction!=0)
                {
                factorialKN *=subtraction;
                subtraction--;
                }

            }

            result = (factorialK * factorialN) / factorialKN ;
            Console.WriteLine("N!*K! / (K-N)!={0}", result);
        }
        else Console.WriteLine("Error!Try again K > N");
    }
}
    

