using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] participants = new IFlyable[] {new Bird(),new Plane() };
            foreach (var item in participants)
            {
                item.Fly();
            }
            Console.ReadKey();
        }
    }
}