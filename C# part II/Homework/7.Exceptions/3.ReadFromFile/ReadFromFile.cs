using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.ReadFromFile
{
    class ReadFromFile
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter path directory to your file:");
            try
            {
                string path = Console.ReadLine();
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);

            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Not found!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is an invalid format");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Enter Path");
            }

        }      
    }
}
