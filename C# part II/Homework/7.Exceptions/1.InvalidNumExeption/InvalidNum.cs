using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InvalidNumExeption
{
    class InvalidNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете цяло положително число");

            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double result = Math.Sqrt(num);
                Console.WriteLine("Kорен квадратен от {0} е {1}", num, result);


            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid Number");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("GoodBye!");
            }

        }
    }
}
