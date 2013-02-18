using System;

    class Recangle_sArea
    {
        static void Main()
        {         
            Console.Write("Въведете страната а=");
            double a=double.Parse(Console.ReadLine());
            Console.Write("Въведете страната b=");
            double b = double.Parse(Console.ReadLine());
            double S;
            S = a * b;
            Console.WriteLine("Лицето на правоъгълника е:{0}",S);

        }
    }

