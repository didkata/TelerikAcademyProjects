using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;
        int third = 0;
        int sum=0;

     
        for (int i = 2; i < n; i++)
        {
            third = first + second;
            first = second ;
            second =third;
            sum += third;
          
        }
        Console.WriteLine("The sum is:{0}",sum+1);
    }
}
