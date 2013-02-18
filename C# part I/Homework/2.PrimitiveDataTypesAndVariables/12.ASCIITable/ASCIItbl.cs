using System;
using System.Text;

class ASCIItbl
{
        static void Main()
        {
           
            for (int i = 0; i < 127; i++)
            {

                Console.WriteLine("DEC {0} HEX {0:X} ASCII {2}", i, i, (char)i);
            }
        }
}
