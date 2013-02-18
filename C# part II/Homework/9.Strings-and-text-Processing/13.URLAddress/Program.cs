using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.URLAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter address in the format:[protocol]://[server]/[resource]");
            string address = Console.ReadLine();

            int index = address.IndexOf("//");
            int indexS = address.IndexOf("/",index + 1);
            string protocol = address.Substring(0, index);
            string server = address.Substring(index + 1, indexS);
        }
    }
}
