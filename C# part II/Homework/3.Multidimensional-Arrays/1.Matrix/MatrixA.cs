using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Matrix(n,n), n=");
        int n = int.Parse(Console.ReadLine());
        int cells = n * n;
        int[,] matrix = new int[n, n];
        int count = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = count++;
            }
            
        }
            for (int row = 0; row < n ; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 3}", matrix[row, col]);
                }
                Console.WriteLine();
            }        
    }
}
