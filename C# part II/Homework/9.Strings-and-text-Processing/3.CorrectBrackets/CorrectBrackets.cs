using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CorrectBrackets
    {
        static void Main(string[] args)
        {
       
            string expression = "((a+b) /5-d)";
            StringBuilder result = new StringBuilder();

            for (int i = 0; i <expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    result.Append('(');
                }
                else if (expression[i] == ')')
                {
                    if (result.Length == 0)
                    {
                        Console.WriteLine("Incorrect");
                        return;
                    }
                    else
                    {
                        result.Remove(result.Length - 1, 1);
                    }
                }
            }
            Console.WriteLine("Correct brackets!");
        }
    }

