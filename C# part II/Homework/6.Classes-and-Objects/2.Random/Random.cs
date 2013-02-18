using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();

        for (int i = 0; i <10; i++)
        {
            Console.WriteLine(randomGen.Next(100,201));

        }
    }
}

