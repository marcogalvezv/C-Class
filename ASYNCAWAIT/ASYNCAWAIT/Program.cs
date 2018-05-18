using System;
using System.Threading;
using System.Threading.Tasks;

namespace ASYNCAWAIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }

        private static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
        }

        private static void LongTask()
        {
            Thread.Sleep(20000);
        }
    }
}
