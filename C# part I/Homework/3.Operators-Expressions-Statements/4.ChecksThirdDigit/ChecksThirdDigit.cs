using System;

class ChecksThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Enter number to check:");
            int Num = int.Parse(Console.ReadLine());
            if ((Num / 100) % 10 == 7)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

