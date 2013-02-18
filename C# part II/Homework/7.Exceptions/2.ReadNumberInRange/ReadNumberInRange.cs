using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReadNumberInRange
{
    class ReadNumberInRange
    {
        static void ReadNumber(int start, int end)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                try
                {               
                    arr[i] = int.Parse(Console.ReadLine());
                    if (arr[i] < 1 || arr[i] > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You entered number out of the range!"); break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number is not in the correct format!!!"); break;
                }
            }
           
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers in range [0...100]");
           
            ReadNumber(1,100);
            
        }
    }
}
