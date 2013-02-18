using System;

class ExchangeVar
    {
        static void Main()
        {
            Console.WriteLine("Enter two variables:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
                Console.WriteLine("The exchanges variable values are: {0} and {1}",a,b);
            }
            else
            {
                Console.WriteLine("Error!The second variable is greater,can't exchange them!");
            }
        }
    }

