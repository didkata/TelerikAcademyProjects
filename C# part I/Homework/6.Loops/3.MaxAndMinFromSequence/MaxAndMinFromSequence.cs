using System;

class MaxAndMinFromSequence
{
    static void Main()
    {
        int min = int.MinValue;
        int max = int.MaxValue;
        Console.WriteLine("How much numbers do you want to enter:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter a number:");
            int sequence = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                min = sequence;
                max = sequence;
            }
            if (sequence < min)
            {
                min = sequence;
            }
            if (sequence > max)
            {
                max = sequence;
            }

        }
        Console.WriteLine("The min number is: {0}", min);
        Console.WriteLine("The max number is: {0}", max);
    }
}
