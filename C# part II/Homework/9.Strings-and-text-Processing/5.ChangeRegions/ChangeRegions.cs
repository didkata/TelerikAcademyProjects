using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ChangeRegions
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>.We don't have <upcase>anything</upcase> else.";
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text.Substring(i,8) == "<upcase>")
            {
                startIndex = i + 8;
                i = startIndex;
            }
            if (text.Substring(i, 9) == "</upcase>")
            {
                endIndex = i;

                int length = endIndex - startIndex;
                string upper = text.Substring(startIndex, length).ToUpper();
                text = text.Remove(startIndex, length);
                text = text.Insert(startIndex, upper);
                text = text.Remove(startIndex - 8, 8);
                text = text.Remove(endIndex - 8, 9);
            }
        }
        Console.WriteLine(text);
    }
}
 

  