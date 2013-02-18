using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Alphibet
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter word: ");
            string word=Console.ReadLine();
            string[] alphabet = { "a", "b", "c" , "d", "e", "f", "g" };
            Array.Sort(alphabet);
            foreach (var letter in word)
            {
                Console.WriteLine(Array.BinarySearch(alphabet, letter));
            }
            
        }
    }
}
