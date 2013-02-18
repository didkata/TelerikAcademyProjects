using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter the first numeber:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second numeber:");
        int y = int.Parse(Console.ReadLine());
        int remainder;

        if (y == 0)
        {
            Console.WriteLine("The greatest common divisor is:{0}",x);
        }
        else if (y != 0)
        {
            if(x < y)
            {
                int temp=x;
                x = y;
                y = temp;
            }
            do
            {
               remainder= x % y;
               x = y;
               y = remainder; 
            }
            while (remainder != 0);

            Console.WriteLine("The greatest common divisor is:{0}", x);
        }
      
    }
}

 