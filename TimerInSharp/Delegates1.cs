using System;
namespace TimerInSharp
{
    delegate int Transformer(int x);

    public class Delegates1 : TISBase
    {

        public Delegates1()
        {
            cout("construct Delegates1");
        }

        public void execute()
        {
            cout("execute Delegates1 ");
            sample1();
        }

        private int square(int x)
        {
            return x * x;
        }

        /// <summary>
        /// Simple delegate
        /// </summary>
        public void sample1()
        {
            cout("execute sample1 ...");
            Transformer t = square;
            cout("t(3)=" + t(3));
        }


    }
}
