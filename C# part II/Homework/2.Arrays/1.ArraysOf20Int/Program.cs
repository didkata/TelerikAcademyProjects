using System;

class ArraysOf20Int
{
    static void Main()
    {
        int[] arr = new int[20];
        for (int index = 0; index < arr.Length; index++)
        {
            arr[index]=index * 5;
            Console.WriteLine("element[{0}]={1}",index,arr[index]);
        }
    }
}