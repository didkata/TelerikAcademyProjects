using System;

class Greetings
{
   static void Greeting(string name)
    {
        Console.WriteLine("Hello, {0}!!!",name);
    }

   static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Greeting(name);
    }
}

