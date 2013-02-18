using System;

class TrapezoidsArea
    {
        static void Main()
        {
            Console.WriteLine("Insert side a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert side b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert hight h:");
            double h = double.Parse(Console.ReadLine());      
            double S = (0.5*(a + b)) * h;
            Console.WriteLine("Trapezoid's area S = {0}",S );

        }
    }