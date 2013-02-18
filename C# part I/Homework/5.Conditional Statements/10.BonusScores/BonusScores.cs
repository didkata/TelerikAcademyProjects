using System;

    class BonusScores
    {
        static void Main()
        {
            Console.WriteLine("Enter your scores:press 1-[1..3] or 2-[4..6] or 3-[7..9]");
            int scores = int.Parse(Console.ReadLine());

            switch (scores)
            {
                case 1: Console.WriteLine("Enter your scores between [1..3]");
                    int realscores = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your scores ({0}) * 10 = {1}",realscores,realscores*10);
                    break;
                case 2: Console.WriteLine("Enter your scores between [4..6]");
                    int realscores1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your scores ({0}) * 100 = {1}", realscores1, realscores1 * 100);
                    break;
                case 3: Console.WriteLine("Enter your scores between [7..9]");
                    int rscores = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your scores ({0}) * 1000 = {1}", rscores, rscores * 1000);
                    break;

                default: Console.WriteLine("Error!Enter scores between [1..9]!");
                    break;
            }
        }
    }

