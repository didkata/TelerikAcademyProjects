using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int len = 1;
        int bestlen = 0;
        int bestElement = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                len++;
            }
            else
            {
                if (len > bestlen)
                {
                    bestlen = len;
                    bestElement = array[i];
                }
                len = 1;
            }
        }
     Console.WriteLine("The longest sequence of {0} elements of type \"{1}\" .",bestlen, bestElement);
   }
}


