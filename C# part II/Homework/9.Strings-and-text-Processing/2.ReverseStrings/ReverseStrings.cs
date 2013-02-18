using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ReverseStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to reverse:");
            string word = Console.ReadLine();

            char[] reversed = word.ToCharArray();
            Array.Reverse(reversed);
            Console.WriteLine(reversed);

            //second way
            //StringBuilder reversed=new StringBuilder();
            //for (int i = word.Length-1; i >=0; i--)
            //{		
            //    reversed.Append(word[i]);
            //}
            //Console.WriteLine(reversed.ToString());
        }
    }

