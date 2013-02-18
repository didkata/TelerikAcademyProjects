using System;

class SandGlass
{
    static void Main()
    {
        Console.WriteLine("Enter the height of the sand-glass N;");
        int n = int.Parse(Console.ReadLine());
   
        for (int row = 0; row < n/2+1; row++)
        {
           int dots=row;
           int asterisk = n - 2 * dots;
            Console.Write(new string('.',dots));
            Console.Write(new string('*',asterisk));
            Console.Write(new string('.',dots));
            Console.WriteLine();
        }

        for (int row = n/2-1; row >=0; row--)
        {
            int dots = row;
            int asterisk = n - 2 * dots;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dots));
            Console.WriteLine();
        }
    }
}
