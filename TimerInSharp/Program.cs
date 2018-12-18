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
            te.Execute();
            Console.WriteLine("Timer in C# :: end");
        }
    }
}
