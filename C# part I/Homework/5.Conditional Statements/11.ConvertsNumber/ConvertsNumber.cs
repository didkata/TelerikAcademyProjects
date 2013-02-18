using System;

class ConvertsNumber
{
    public static void Ones(int input)
    {
        switch (input)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            default:
                break;
        }           
    }
    public static void Teens(int input)
    {
        switch (input)
        {
            case 10: Console.WriteLine(" Ten"); break;
            case 11: Console.WriteLine(" Eleven"); break;
            case 12: Console.WriteLine(" Twelve"); break;
            case 13: Console.WriteLine(" Thirteen"); break;
            case 14: Console.WriteLine(" Fourteen"); break;
            case 15: Console.WriteLine(" Fifteen"); break;
            case 16: Console.WriteLine(" Sixteen"); break;
            case 17: Console.WriteLine(" Seventeen"); break;
            case 18: Console.WriteLine(" Eighteen"); break;
            case 19: Console.WriteLine(" Nineteen"); break;
            default:
                break;
        }      
    }
    public static void Tens(int input)
    {
        switch (input)
        {
            case 2: Console.Write(" Twenty "); break;
            case 3: Console.Write(" Thirty "); break;
            case 4: Console.Write(" Fourty "); break;
            case 5: Console.Write(" Fifty "); break;
            case 6: Console.Write(" Sixty "); break;
            case 7: Console.Write(" Seventy "); break;
            case 8: Console.Write(" Eighty "); break;
            case 9: Console.Write(" Ninety "); break;
            default:
                break;
        }
    }
    public static void Hundreds(int input)
    {
        switch (input)
        {
            case 1: Console.Write("One"); break;
            case 2: Console.Write("Two"); break;
            case 3: Console.Write("Three"); break;
            case 4: Console.Write("Four"); break;
            case 5: Console.Write("Five"); break;
            case 6: Console.Write("Six"); break;
            case 7: Console.Write("Seven"); break;
            case 8: Console.Write("Eight"); break;
            case 9: Console.Write("Nine"); break;

            default:
                break;
        }
        Console.Write(" hundred ");
    }
    static void Main()
    {
        Console.WriteLine("Enter number in this range [0...999]:");
        int input = int.Parse(Console.ReadLine());


        if (input >= 0 && input <= 9)
        {
            Ones(input);
        }

        else if (input >= 10 && input <= 19)
        {
            Teens(input);
        }

        else if (input >= 20 && input <= 99)
        {
            int first = input / 10;
            int second = input % 10;

            if (second == 0)
            {
                Tens(first);
            }
            else
            {
                Tens(first);
                Ones(second);
            }
        }
        else if (input >= 100 && input <= 999)
        {
            int hundreds = input / 100;
            int tens = (input / 10) % 10;
            int ones = input % 10;
            Hundreds(hundreds);

            int specials = input % 100;
            int one = input % 100;
            if ((one > 0 && one < 10) || (specials >= 10 && specials < 20) && specials != 0)
            {
                Console.Write("and ");
                Ones(one);
            }
            if (specials >= 10 && specials <= 19)
            {
                Teens(specials);
            }
            int noZero = input % 100;
            if (noZero == 0)
            {
                Hundreds(noZero);
            }
            else if (input >= 20 && input <=999)
            {
                Tens(tens);
                int zeroChecker = input % 100;
                int zeroChecker1 = input % 10;

                if (zeroChecker1 != 0 && zeroChecker != 1 && zeroChecker != 2 && zeroChecker != 3 && zeroChecker != 4
                    && zeroChecker != 5 && zeroChecker != 6 && zeroChecker != 7 && zeroChecker != 8 && zeroChecker != 9
                    && !(specials >= 10 && specials < 20))
                {
                    Ones(ones);
                }

            }
        }
    }

}
