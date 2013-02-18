using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Въведете число различно от нула за а:");
        double a = double.Parse(Console.ReadLine());       
        if (a == 0)
        Console.WriteLine("Въведете число различно от нула");
        Console.WriteLine("Въведете число за b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Въведете число c:");
        double c = double.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);

        if (D < 0)
        {
            Console.WriteLine("Дискриминантата е :{0}", D);
            Console.WriteLine("Квадратното уравнение няма реални корени");
        }
        else
            if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Дискриминантата е :{0}", D);
                Console.WriteLine("Квадратното уравнение има един корен x= {0}", x);
            }
            else
                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Дискриминантата е :{0}", D);
                    Console.WriteLine("Квадратното уравнение има корени X1={0} и X2={1}", x1, x2);
                }
    }
}