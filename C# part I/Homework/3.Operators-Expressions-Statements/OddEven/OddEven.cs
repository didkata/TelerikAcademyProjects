using System;

class OddEven
{
    static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
         
        if(a % 2==0)
            Console.WriteLine("Числото {0} е четно", a);
        else
            Console.WriteLine("Числото {0} е нечетно!",a);
    }
}
 

