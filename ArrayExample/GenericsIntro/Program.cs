using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Check<int> c = new Check<int>();
            var r = c.Compare(5, 6);

            Console.WriteLine(r);

            Check<string> sc = new Check<string>();
            var sr = sc.Compare("TEST", "TEST");
            Console.WriteLine(sr);

            Console.ReadLine();

        }
    }
}
