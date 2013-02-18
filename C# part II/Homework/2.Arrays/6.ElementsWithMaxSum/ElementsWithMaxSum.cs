using System;

class ElementsWithMaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter number for N");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number for K < N");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an array of N elements:");
        //int n = 4;
        //int k = 2;
        int[] array = new int[n];


        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
      
        Console.WriteLine("{0} {1}  have the biggest sum:", array[n-2],array[n-1]);
    }
}
