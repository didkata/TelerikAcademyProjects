using System;

class ThreeTasksSolve
{
    static void ReverseDigits()
    {
       Console.WriteLine("Въведете число > 0: ");
        int num = int.Parse(Console.ReadLine());
       if (num < 0)
       {
           while (true)
           {
               Console.WriteLine("Грешка! Въведете неотрицателно число!");
               num = int.Parse(Console.ReadLine());
               if (num > 0)
               {
                   break;
               }
           }
       }
        do
        {
           int reversed = num % 10;
            num = num / 10;
            Console.Write(reversed);
        }
        while (num != 0);
        Console.WriteLine();
    }

    static void AvgOfSeqOfInt()
    {
        Console.WriteLine("Въведете дължината на редицата:");
        int length = int.Parse(Console.ReadLine());
        if (length==0)
        {
           while (true)
           {
               Console.WriteLine("Грешка! Редицата не може да бъде празна!Въведете друга дължина");
               length= int.Parse(Console.ReadLine());
               
               if (length != 0)
               {
                   break;
               }
           }
       }
        Console.WriteLine("Въведете членовете на редицата:");
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum=0;
        for (int i = 0; i < length; i++)
        {
           
            sum = sum + arr[i];
        }
        float average = sum / 2;
        Console.WriteLine("Средното аритметично на дадената редица е:{0}",average);

    }

    static void LinerEquation()
    {
        Console.WriteLine("Въведете число за а (а различно от 0):");
        double a = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            while (true)
            {
                Console.WriteLine("Грешка! Въведете число различно от 0;");
                a = double.Parse(Console.ReadLine());
                if (a != 0)
                {
                    break;
                }
            }
        }
        Console.WriteLine("Въведете число за b:");
        double b = double.Parse(Console.ReadLine());
        double x;
        x = -b / a;
        Console.WriteLine("Резултатът от линейното уравнение:{0}",x);

    }


    static void Main()
    {
        Console.WriteLine("Моля изберете опция от менюто:\n 1-Обръща последователността на цифрите на едно число.\n 2-Пресмята средното аритметично на дадена поредица от числа\n 3-Решава линейното уравнение a * x + b = 0.");
        int choice = int.Parse(Console.ReadLine());
       
        switch (choice)
        {
            case 1: ReverseDigits();
                break;
            case 2: AvgOfSeqOfInt();
                break;
            case 3: LinerEquation();
                break;
            default:
                break;
        }
       
    }
}

