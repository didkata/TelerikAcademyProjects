using System;

class TriangleSurface
{
    static void sideAndAltitude()
    {
        Console.WriteLine("Enter side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter altitude h:");
        double h = double.Parse(Console.ReadLine());
        double S = (a * h) / 2;
        Console.WriteLine("The surface of the triangle is:{0}", S);


    }

    static void threeSidesHerons()
    {
        Console.WriteLine("Enter side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side c:");
        double c = double.Parse(Console.ReadLine());

        double p = (a + b + c) / 2;
        double temp =p * (p-a)*(p-b)*(p-c);
        double S = Math.Sqrt(temp);
        Console.WriteLine("The surface of the triangle is:{0}", S);

    }
    static void twoSidesAndAngle()
    {
        Console.WriteLine("Enter side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter angle:");
        double angle = double.Parse(Console.ReadLine());
        double S= (a * b * Math.Sin(Math.PI *angle/180)) / 2;
        Console.WriteLine("The surface of the triangle is:{0}", S);
    }


    static void Main()
    {
        Console.WriteLine("Choose how want to find the surface of a triangle by given:\n 1) Side and an altitude to it\n 2) Three sides\n 3) Two sides and an angle between them:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: sideAndAltitude(); break;
            case 2: threeSidesHerons(); break;
            case 3: twoSidesAndAngle(); break;

            default:
                break;
        }
    }
}
