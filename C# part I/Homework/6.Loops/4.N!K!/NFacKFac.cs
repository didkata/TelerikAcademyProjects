using System;

class NFacKFac
{
    static void Main()
    {
        Console.WriteLine("Enter number for N (1<K<N):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number for K:");
        int k = int.Parse(Console.ReadLine());
        decimal factorialN = 1;
        decimal factorialK = 1;
        decimal result;

        if (n > k)
        {
            while (true)
            {
                if (n >= 1)
                {
                    factorialN *= n;
                    n--;
                }
                else break;

                if (k >= 1)
                {
                    factorialK *= k;
                    k--;
                }

            }

            result = (factorialN / factorialK);
            Console.WriteLine("N!/K!={0}", result);
        }
        else Console.WriteLine("Error!Try again N > K");
    }
}