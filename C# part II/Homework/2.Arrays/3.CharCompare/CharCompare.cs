using System;

class CharCompare
{
    static void Main()
    {
        char[] first = { 'a', 'b', 'c', 'd', 'e' };
        char[] second = { 'a', 'b', 'c', 'e', 'd', };
        bool equal = true;

        if (first.Length == second.Length)
        {
            for (int i = 0; i < first.Length; i++)
            {

                if (first[i] != second[i])
                {
                    equal = false;
                    break;
                }
            }
        }
        else equal = false;
        Console.WriteLine("Arrays are equal:{0}", equal);
    }
}
