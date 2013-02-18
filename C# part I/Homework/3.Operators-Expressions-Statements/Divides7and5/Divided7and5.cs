using System;

class Divided7and5
    {
        static void Main()
        {
           Console.Write("a=");
           int a = int.Parse(Console.ReadLine());
            
            bool b=( a % 7 ==0 && a % 5==0);
            Console.WriteLine("{0}",b);         
           
        }
    }

