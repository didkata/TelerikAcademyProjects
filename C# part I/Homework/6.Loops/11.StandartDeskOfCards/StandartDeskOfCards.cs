using System;

class StandartDeskOfCards
{
    static void Main()
    {
        for (int dye = 1; dye <= 4; dye++)   
        {
            for (int cards = 2; cards <= 14; cards++)
            {
                switch (cards)
                {
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                    case 10: Console.Write("Ten"); break;
                    case 11: Console.Write("J"); break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;

                }
                Console.Write(" of ");
                switch (dye)
                {
                    case 1: Console.WriteLine("Clubs"); break;
                    case 2: Console.WriteLine("Diamonds"); break;
                    case 3: Console.WriteLine("Hearts"); break;
                    case 4: Console.WriteLine("Spades"); break;
                }
            }
        }
    }
}
        
    
