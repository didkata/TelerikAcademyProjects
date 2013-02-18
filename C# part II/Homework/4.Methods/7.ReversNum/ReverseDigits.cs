using System;

class ReversDigits
{
    static void Reverse(int num)
    {
        do
        {
             int reversed = num % 10;
             num = num/10;
             Console.Write(reversed);
        }
        while (num != 0);   
    }

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        Reverse(num);
    }
}
