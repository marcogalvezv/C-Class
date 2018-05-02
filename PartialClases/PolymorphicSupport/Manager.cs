using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphicSupport
{
    class Manager:Employee
    {
        public Manager(string name, int id, int age, float pay, string socialSecurityNumber, int stockOptions) : base(name, id, age, pay, socialSecurityNumber)
        {
            StockOptions = stockOptions;
        }

        public int StockOptions { get; private set; }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }
    }
}
