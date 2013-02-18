using System;

class MostFrequentNumInArray
{
    static void Main()
    {
        int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int c = 1;
        int maxC = 0;
        int bestElement = 0;
        Array.Sort(arr);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                c++;
            }
            else
            {
                if (c > maxC)
                {
                    maxC = c;
                    bestElement = arr[i];

                }
                c = 1;
            }

        }
        Console.WriteLine("The most frequent num is {0}.There is {1} times",  bestElement,maxC);
    }
}