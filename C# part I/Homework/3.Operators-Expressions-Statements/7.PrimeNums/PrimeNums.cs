using System;

class PrimeNums
{
    static void Main()
    {
        Console.WriteLine("Insert number to check:");
        int num = int.Parse(Console.ReadLine());
        int sqrt = (int)Math.Sqrt(num);
        int i = 2;
        bool prime = true;
        while (prime && i <= sqrt)
        {
            if (num % i == 0)
            {
                prime = false;
            }
            i++;
        }
        if (!prime)
        {
            Console.WriteLine("The number is not prime!");
        }
        if (prime)
        {
            Console.WriteLine("The number is prime!");
        }
    }
}


 
   

