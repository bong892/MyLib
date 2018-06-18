using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabyCarrot.Tools;
using BabyCarrot.Extensions;

namespace BabyCarrotTest
{
    class Program
    {
        static void Main(string[] args)
        {
 /*           string contents = "Hello there, <br />This is Derek.";
            EmailManager.Send("receiver@test.com", "Hi...", contents);

            */
        
            LogManager log = new LogManager(null, "_BabyCarrotTest");

            log.WriteLine("[Begin Processing]........");

            for (int index = 0; index < 10; index++)
            {
                log.WriteLine("Processing: " + index);

                // Do
                System.Threading.Thread.Sleep(500);

                log.WriteLine("Done:" + index);
            }

            log.WriteLine("[End Processing]........");

    
        }
    }

    public static class ExtnsionTest
    {
        public static void WriteConsole(this LogManager log, string data)
        {
            log.Write(data);
            Console.Write(data);
        }
    }

}
