using System;

class ShowTheSign
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers:");
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        double third = double.Parse(Console.ReadLine());       
        int count=0;

        if (first == 0 || second == 0 || third == 0)
        {
            Console.WriteLine("The product is ZERO");
        }
        else
        {
            if (first < 0)
            {
                count++;
            }
            if (second < 0)
            {
                count++;
            }
            if (third < 0)
            {
                count++;
            }
            if (count % 2 == 0)
            {
                Console.WriteLine("The product sign will be (+)");
            }
            else
            {
                Console.WriteLine("The product sign will be (-)");
            }
        }
    }
}


