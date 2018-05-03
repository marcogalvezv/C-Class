using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Plane : AbstractCar, IFlyable, IRollable
    {
        public void Roll()
        {
            Console.WriteLine("Plane Rolling");

        }

        void IFlyable.Fly()
        {
            Console.WriteLine("Plane Flying");
        }
    }
}
