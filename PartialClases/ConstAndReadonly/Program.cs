using System;

namespace ConstAndReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void LocalConstStringVariable()
        {
            // A local constant data point can be directly accessed.
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);
            // Error!
            // fixedStr = "This will not work!";
        }
    }

    class MyMathClass
    {
        // Try to set PI in ctor?
        public const double PI;
        public MyMathClass()
        {
            // Not possible- must assign at time of declaration.
            PI = 3.14;
        }
    }


    class MyMathClass1
    {
        public static readonly double PI;
        static MyMathClass1()
        { PI = 3.14; }
    }
}