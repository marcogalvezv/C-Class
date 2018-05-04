using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        static List<int> MyList = new List<int>();
        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }
        static void Main(string[] args)
        {
            FillValues();
            //foreach (int i in MyList)
            //{
            //    Console.WriteLine(i);
            //}
            foreach (int i in FilterYield())
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        static IEnumerable<int> Filter()
        {
            List<int> temp = new List<int>();
            foreach (int i in MyList)
            {
                if (i > 3)
                {
                    temp.Add(i);
                }
            }
            return temp;
        }


        static IEnumerable<int> FilterYield()
        {
            foreach (int i in MyList)
            {
                if (i > 3)
                {
                    yield return i;
                }
            }
        }
    }
}