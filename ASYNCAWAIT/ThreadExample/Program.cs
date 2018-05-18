using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread o1 = new Thread(RunMillionIterarions);
            o1.Start();
            //Parallel.For(0, 1000000, x => RunMillionIterarions());
            Console.Read();
        }

        private static void RunMillionIterarions()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + "s";
            }
        }
    }
}
