using System;
using System.Text;
class CopyRight
    {
        static void Main()
        {
            char copyright = '\u00A9';
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(@"
{0}
{0}{0}{0}
{0}{0}{0}{0}", copyright);
        }

    }

