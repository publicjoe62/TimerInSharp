
using System;
using System.Threading;

namespace TimerInSharp
{
    public class FeedCheck
    {
        static int _count = 0;
        static object _consumingSync = new object();
        static System.Threading.Timer _produceTimer = null;

        private static void Consume()
        {
            if (!Monitor.TryEnter(_consumingSync)) return;

            try
            {
                while (_count > 0)
                {
                    Interlocked.Decrement(ref _count);
                }
            }
            finally
            {
                Monitor.Exit(_consumingSync);
            }
        }

        private static void Produce(object state)
        {
            Console.WriteLine("Produce");
            Consume();
        }

        public static void Start()
        {
            // small risk of race condition here, but no necessarily
            // be bad if multiple Timers existed for a moment, since only
            // the last one will survice
            if ( _produceTimer == null )
            {
                /*
                _produceTimer = new System.Threading.Timer(
                    _ => FeedCheck.Produce(), null, 0, 1000
                );
                */

                _produceTimer = new System.Threading.Timer(Produce, null, 0, 1000);

            }
        }
    }
}
