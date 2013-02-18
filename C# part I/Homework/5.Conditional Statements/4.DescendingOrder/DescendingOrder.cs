using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter three values to sort:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a < b)
        {
            if (a < c)
            {
            }
            if (b < c)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else
            {
                double change = c;
                c = b;
                b = change;

                if (a < b == false)
                {
                    double temp2 = b;
                    b = a;
                    a = temp2;
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
        
            }
        }
        else
            if (b < c)
            {
                double temp = b;
                b = a;
                a = temp;
                if (b < c == false)
                {
                    double temp1 = c;
                    c = b;
                    b = temp1;
                }
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else
            {
                if (a < c)
                {
                }
                double d = c;
                c = a;
                a = d;
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
    }
}