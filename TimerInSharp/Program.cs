using System;
using System.Threading;

namespace TimerInSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TimerExample te = new TimerExample();
            Console.WriteLine("Timer in C# :: start");


            /*
            // FeedCheck
            //
            // FeedCheck fc = new FeedCheck();
            FeedCheck.Start();
            */

            /*
            // Timer example
            //
            te.Execute();
            */

            /*
            Console.WriteLine("press enter to stop.");
            Console.ReadLine();
            Console.WriteLine("Timer in C# :: end");
            */

            Lambda.lambda1();
        }
    }
}
