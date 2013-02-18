using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FilledStars
{
    static void Main(string[] args)
    {
        StringBuilder text = new StringBuilder(20);
        Console.WriteLine("Enter string of max 20 characters");
        string textIn = Console.ReadLine();

        StringBuilder final = text.Append(textIn);

        int result = 0;
        if (final.Length < 20)
        {
            result = text.Capacity - text.Length;
            Console.Write("This is the result:{0}", final);
            for (int i = final.Length; i < final.Length + result; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}