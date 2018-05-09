using System;

namespace Events
{
    class Program
    {
        delegate int NumberFunction(int i);
        static void Main(string[] args)
        {
            NumberFunction func = Square;             
            Console.WriteLine("result of delegate is: {0}", func(5));
            func = Cube;
            Console.WriteLine("result of delegate is: {0}", func(5));
            Console.ReadLine();
        }

        static int Square(int n)
        {
            return n * n;
        }

        static int Cube(int n)
        {
            return n * n * n;
        }


    }
}