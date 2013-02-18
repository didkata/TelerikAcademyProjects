using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Въведете дължина на масива и масив:" );
        int n=int.Parse(Console.ReadLine());
        int [] array=new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Въведете числото чийто индекс желаете да разберете:");
        int x = int.Parse(Console.ReadLine());
        Array.Sort(array);
       
        int result=Array.BinarySearch(array,x);
        Console.WriteLine("Индексът на числото {0} е:{1}",x , result);
    }
}