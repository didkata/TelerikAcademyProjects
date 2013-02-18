using System;

class Sorting
{
    static void SortArray(int[] array)
    {
        int i = array.Length - 1;

        Array.Sort(array);
        Console.WriteLine("Sorted array:");

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(" " + array[index]);
        }
        Console.WriteLine();
        Console.WriteLine("The maximal element is: {0}", array[i]);

    }
    static void Main()
    {
        int[] array = { 1, 5, 7, 2, 4, 3, 6, 10, 56, 98, 45, 65, 0, 23 };

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(" " + array[index]);
        }
        Console.WriteLine();
        SortArray(array);
    }
}
