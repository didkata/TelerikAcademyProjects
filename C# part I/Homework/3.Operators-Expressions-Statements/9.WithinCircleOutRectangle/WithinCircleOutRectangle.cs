using System;

class WithinCircleOutRectangle
{
    static void Main()
     {
            Console.WriteLine("Въведете координати за х:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете координати за y:");
            double y = double.Parse(Console.ReadLine());
            double radius = 3;
            bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius;
            bool inRectangle = ((x >= -1) && (x <=5)) && ((y >= -1) && (y <= 1));
            
        if (inCircle==true && inRectangle==false)
            {
                Console.WriteLine("Точката е в кръга и извън правоъгълника");
            }

        else
                    Console.WriteLine("Точката е в кръга и в правоъгълника");
        }
}

  

