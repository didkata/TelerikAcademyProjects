using System;

class SequenceOfFibonacci
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 0; i <100; i++)
        {
            int temp = a+b;
            Console.WriteLine(temp);
            a = b;
            b = temp;            
        }     
    }
}

