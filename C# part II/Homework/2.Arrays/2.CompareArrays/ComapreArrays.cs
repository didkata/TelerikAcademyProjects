using System;

class ComapreArrays
{
    static void Main()

    {
        Console.WriteLine("Insert length of the first array:");
        int length1 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[length1];

        for (int i = 0; i < length1; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
   
        }
        Console.WriteLine("Insert length of the second array:");
        int length2 = int.Parse(Console.ReadLine());
        int[] arr2 = new int[length2];
       
        for (int i= 0; i < length2; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        bool equal = true;
        if (length1 == length2)
        {
            for (int i = 0; i < length1; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    equal = false;
                    break;
                }
            }
        }
        else equal = false;  
       Console.WriteLine("The two arrays are equal:{0}",equal);
    }
}
