using System;
class Compare
{
    static void Main()
    {
        float a = 5.55f;
        float b = 6.35f;
        Boolean Compare = (a == b);
        Console.WriteLine("The result is {0}", Compare);
        Boolean Compare1 = (a > b);
        Console.WriteLine("The result is {0}", Compare1);
        Boolean Compare2 = (a < b);
        Console.WriteLine("The result is {0}", Compare2);
    }
}

