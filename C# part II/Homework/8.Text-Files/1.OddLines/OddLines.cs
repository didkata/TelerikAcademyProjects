using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../Sample.txt");
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
