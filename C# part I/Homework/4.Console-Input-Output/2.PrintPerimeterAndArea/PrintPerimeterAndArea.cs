using System;

class PrintPerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of th circle:");
        double r= double.Parse(Console.ReadLine());
        double Perimeter = 2 * (Math.PI*r);
        double Area = Math.PI *( r * r);

        Console.WriteLine("Circle's perimeter is:{0:0.000} and it's area is:{1:0.000}\n",Perimeter,Area);

    }
}
