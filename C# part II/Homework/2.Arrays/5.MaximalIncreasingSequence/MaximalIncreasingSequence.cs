using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
       
        int len = 1;
        int bestlen = 0;
        int bestRow = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                len++;
            }
            else
            {

                if (len > bestlen)
                {
                    bestlen = len;
                    bestRow = i;
                }
                len = 1;
            }
        }
        if (len > bestlen)
        {
            bestlen = len;
            bestRow = array.Length-1;
        }
        len = 1;
        Console.Write("\n{ ");
        for (int i = bestRow - bestlen+1; i < bestRow+1; i++)
        {
            Console.Write(array[i]);
        }
        Console.Write(" }");
    }
}