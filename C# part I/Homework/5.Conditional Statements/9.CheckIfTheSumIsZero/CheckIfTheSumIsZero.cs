﻿using System;
using System.Globalization;
using System.Threading;

class CheckIfTheSumIsZero
{
    static void Main()
    {
        int a, b, c, d, e;
        Console.Write("Enter the first number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        c = int.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        d = int.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        e = int.Parse(Console.ReadLine());

        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }
        else if (a + b + c + d == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} + {3} = 0", a, b, c, d);
        }
        else if (a + b + c + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} + {3} = 0", a, b, c, e);
        }
        else if (a + b + c == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", a, b, c);
        }
        else if (a + b + d == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", a, b, d);
        }
        else if (a + b + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", a, b, e);
        }
        else if (a + d + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", a, d, e);
        }
        else if (a + c + d == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", a, c, d);
        }
        else if (a + c + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", a, c, e);
        }
        else if (a + b == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", a, b);
        }
        else if (a + c == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", a, c);
        }
        else if (a + d == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", a, d);
        }
        else if (a + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", a, e);
        }
        else if (b + c == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", b, c);
        }
        else if (b + c + d == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", b, c, d);
        }
        else if (b + c + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", b, c, e);
        }
        else if (b + d == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", b, d);
        }
        else if (b + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", b, e);
        }
        else if (c + d == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", c, d);
        }
        else if (c + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", c, e);
        }
        else if (d + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} = 0", d, e);
        }
        else if (b + c + d + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} + {3} = 0", b, c, d, e);
        }
        else if (c + d + e == 0)
        {
            Console.WriteLine("The subset of {0} + {1} + {2} = 0", c, d, e);
        }

        else
            Console.WriteLine("The sum of subset is not null");


    }
}