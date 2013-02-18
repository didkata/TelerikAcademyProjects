using System;

    class CheckTheBit
    {
        static void Main()
        {
            int pos = 3;
            int num =254;
            int mask = 1 << pos;
            int SumNandP = num & mask;
            int bit = SumNandP >> pos;
            bool result = (bit == 1);
            if (result)
            {
                Console.WriteLine("True=1");
            }
            else { Console.WriteLine("False=0"); }
       
        }
    }

