using System;

class HowManyTimes
{
    static void HowManyTimesAppearNum(int[] arr, int number)
    {
        int count = 0;
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }          
        }
        Console.WriteLine("Number {0} appears {1} times",number, count);
    }

    static void Main()
    {
        int[] arr = { 1, 4, 6, 5, 1, 1, 9, 8, 7, 2, 1 };
        Console.WriteLine("Enter number you want to see,how many times appear:");
        int number = int.Parse(Console.ReadLine());
        HowManyTimesAppearNum(arr, number);
       
    }
}
