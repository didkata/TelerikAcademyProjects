using System;

    class ForbiddenWords

    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            Console.WriteLine(text);
            Console.WriteLine();
            string newText = text.Replace("PHP", "***").Replace("CLR","***").Replace("Microsoft","*********");
            Console.WriteLine(newText);
        }
    }

