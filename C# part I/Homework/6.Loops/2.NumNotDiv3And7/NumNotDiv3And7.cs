using System;

class NumNotDiv3And7
{
    static void Main()
    {
        Console.WriteLine("Enter number for n:");
        int n = int.Parse(Console.ReadLine());
       
        for (int i = 1; i < n; i++)
        {
            if (i % (3 * 7) != 0)
            {
                Console.WriteLine(i);
            }         
        }    
    }
}
