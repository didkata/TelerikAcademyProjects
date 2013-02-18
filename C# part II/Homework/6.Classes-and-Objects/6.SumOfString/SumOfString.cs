using System;
using System.Collections.Generic;

class SumOfString
{
    static void Main(string[] args)
    {

        string numbers = "43 68 9 23 318";
        int sum = 0;

        string[] arr = numbers.Split(' ');
        for (int i = 0; i < arr.Length; i++)
        {

            sum = sum + int.Parse(arr[i]);
        }
        Console.WriteLine(sum);
    }
}

       