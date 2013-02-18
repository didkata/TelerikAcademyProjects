using System;

class CalculateSum
    {
        static void Main()
        {
            double counter=2;
            double difference;
            double sumO = 1;
            double sumN;
           
            do
            {
                if ((counter%2)==0)
                {
                    sumN=(sumO+(1/counter));
                    difference=sumN-sumO;
                    counter++;
                    sumO=sumN;
                }
                else
                {
                    sumN=(sumO-(1/counter));
                    difference=Math.Abs(sumN-sumO);
                    counter++;
                    sumO=sumN;
                }
            }
            while (difference > 0.001);
            Console.WriteLine("The sum is {0}", sumN);       
        }
    }
