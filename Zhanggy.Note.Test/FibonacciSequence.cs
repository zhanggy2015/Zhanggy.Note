using System;

namespace Zhanggy.Note.Test
{
    /// <summary>
    /// 斐波那契数列
    /// </summary>
    public class FibonacciSequence
    {
        public static void Main()
        {
            Console.WriteLine(FibSequence(30));
        }

        public static int FibSequence(int i)
        {
            if (i <= 0)
                return 0;
            else if (i > 0 && i <= 2)
                return 1;
            else return FibSequence(i - 1) + FibSequence(i - 2);
        }
    }
}


