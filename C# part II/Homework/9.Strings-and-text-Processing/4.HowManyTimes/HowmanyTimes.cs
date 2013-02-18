using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HowmanyTimes
{
    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine We don't have anything else.Inside the submarine is very tight.So we are drinking all the day. We will move out of it in 5 days.";
        int index=-1;
        int count=0;
        string lower=text.ToLower();
        while (true)
        {
            index = lower.IndexOf("in",index+1);

            if (index == -1)
            {
                break;
            }
            
            count++;
        }
        Console.WriteLine(count);
    }
}

