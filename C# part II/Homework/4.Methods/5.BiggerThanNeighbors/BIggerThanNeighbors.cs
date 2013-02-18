using System;

class BIggerThanNeighbors
{
     static void BiggerThanN(int[] array, int pos)
    {
        int i = pos;
        if (array[i] > array[i + 1])
        {
            if (array[i] > array[i - 1])
            {
                Console.WriteLine("Числото {0} е по-голямо от съседите си!", array[i]);
            }
            else
            {
                Console.WriteLine("The neighbor on position {0} is bigger than this on position {1}", pos - 1, pos);
            }
        }
        else
        {
            Console.WriteLine("Числото {0} e по-малко от съседите си ",array[i]);
        }

    }
    static void LeftElement(int[] array, int pos)
    {
        int i = pos;
        if (array[i] > array[i + 1])
        {
            Console.WriteLine("Числото {0} има само един съсед - отдясно и е по-голямо от него!", array[i]);
        }
        else
        {
            Console.WriteLine("Числото {0} има само един съсед - отдясно и е по-малко от него!", array[i]);
        }

    }
    static void RightElement(int[] array, int pos)
    {
        int i = pos;
        if (array[i] > array[i-1])
        {
            Console.WriteLine("Числото {0} има само един съсед - отляво и е по-голямо от него!", array[i]);
        }
        else
        {
            Console.WriteLine("Числото {0} има само един съсед - отляво и е по-малко от него!", array[i]);
        }

    }
    static void Main()
    {
        int[] array = {1, 5, 7, 2, 4, 3, 6};
        Console.WriteLine("Това е даденият масив:  ");
        for (int index = 0; index < array.Length; index++)
        {
           Console.Write(" " + array[index]);
        }
        Console.WriteLine();
        Console.WriteLine("Въведете позицията на елемента, които желаете да проверите:");
        int pos = int.Parse(Console.ReadLine());
        int i = pos;

        if (i == 0)
        {
            LeftElement(array, pos);

        }
        else
         {
            if (array[i] == array.Length - 1)
            {
                RightElement(array, pos);

            }

            else
            {
                BiggerThanN(array, pos);
            }
        }
    }
}

