using System;
using System.Threading;

namespace ghoul
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i > 0; i -= 7)
            {
                Console.WriteLine(i + " - 7 = " + (i-7));
                Thread.Sleep(20);
            }
        }
    }
}
