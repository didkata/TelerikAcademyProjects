using System;

class TypeVar
{
    static void Main()
    {
        Console.WriteLine("Enter your type choice:1-int,2-double,3-string");
         int choice =int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter an Int Variable :");
                int varInt= int.Parse(Console.ReadLine());
                Console.WriteLine("Int + 1 : {0}", varInt + 1);
                break;
            case 2: Console.Write("Enter double Variable :");
               double varDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Double + 1 : {0}", varDouble + 1);
                break;
            case 3: Console.Write("Enter string:");
               string varString = Console.ReadLine();
                Console.WriteLine("String + *: {0}", varString +"*");
                break;
            default: Console.WriteLine("Your choice is incorrect!!!");
                break;
        }
    }
}
