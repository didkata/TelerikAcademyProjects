using System;

class DivisionByFive
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integer numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int count=0;

        for (int i = a; a <= b; a++)
        {
            bool division =(a % 5 == 0);

            if (division==true)
                count++;
        }
       
         Console.WriteLine("Съществyват {0} числа между зададените две, които се делят на 5", count);
    }
}
			

