using System;

class Concatenation
{
    static void Main()
    {
        string word = "Hello";
        string word1 = "World";
        object greeting = word + " " + word1;
        Console.WriteLine("{0}!",greeting);
        string casting;        
        Console.WriteLine(casting=greeting.ToString());
   }
}
