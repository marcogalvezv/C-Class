using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird Flying");
        }
    }
}
