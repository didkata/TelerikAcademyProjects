using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter N < 20:");
        int n = int.Parse(Console.ReadLine());
        if (n < 20)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);

                for (int j = i + 1; j < n + i; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }
        }
        else Console.WriteLine("ERROR!!!!!");
    }
}

