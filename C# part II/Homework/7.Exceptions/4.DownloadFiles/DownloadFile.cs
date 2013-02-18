using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _4.DownloadFiles
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            try
            {
                string remoteUri = "http://www.devbg.org/img/";
                string fileName = "Logo-BASD.jpg", myStringWebResource = null; ;
                string path = @"d:\Telerik\";
                myStringWebResource = remoteUri + fileName;
                WebClient webClient = new WebClient();
                webClient.DownloadFile(myStringWebResource, fileName);
                Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource); ;
                Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + path);
            }

            catch (ArgumentException)
            {
                Console.WriteLine("It's an empty address!");
            }
            catch (WebException)
            {
                Console.WriteLine("The file does not exist.");
            }           
       }
    }
}
