using System;
namespace TimerInSharp
{
    public class Lambda
    {
        delegate int Transformer(int i);

        public Lambda()
        {
        }

        public static int lambda1()
        {
            cout("lambda1");
            Transformer sqr = x => x * x;
            int result = sqr(4);

            cout("sqr(4) = " + result);
            return result;
        }

        public static int lambda2()
        {
            int result = 0;

            cout("lambda2");

            return result;
        }

        private static void cout(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
