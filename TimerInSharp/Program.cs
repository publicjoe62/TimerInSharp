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
            */

            // Lambda.lambda1();

            new Delegates1().execute();

            Console.WriteLine("Timer in C# :: end");
        }
    }
}
