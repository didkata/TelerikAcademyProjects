using System;

class TheGreaterNum
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers for comparison:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        bool result = a < b;
        Console.WriteLine(result ? "The greater is {0}" : "The Greater is :{1}",b,a);
        
        //double greater = Math.Max( a, b );
        //Console.WriteLine("The greater number is: {0}", greater);
    }

}

