using System;

class BitAtPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter position of bit:");
            int pos=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter anumber:");
            int v = int.Parse(Console.ReadLine());         
            int mask = 1 << pos;
            int Sum = v & mask;
            int bit = Sum >> pos;
            bool result = (bit == 1);
            if (result)
            {
                Console.WriteLine("False->1");
            }
            else { Console.WriteLine("True->0"); }
       
        }
    }