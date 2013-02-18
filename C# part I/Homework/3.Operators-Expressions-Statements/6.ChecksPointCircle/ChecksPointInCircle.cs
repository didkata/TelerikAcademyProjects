using System;

class ChecksPointInCircle
    {
        static void Main()
        {
            Console.WriteLine("Въведете координати за х:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете координати за y:");
            double y = double.Parse(Console.ReadLine());
            double radius = 5;
            bool result = x * x + y * y <= radius*radius;
            Console.WriteLine(result ? "Точката е в кръга" : "Точката не е в кръга" );
        }
    }

