using System;

class SelectingSort
{
    static void Main()
    {
        int min, temp;
        Console.WriteLine("Enter the length of the array and then numbers in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            
        }
        for (int i = 0; i < n- 1; i++)
        {
            min = i;

            for (int j = i + 1; j < 10; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("array[" + i + "] = " + arr[i]);
        }
    }
}
