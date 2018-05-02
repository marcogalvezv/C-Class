using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphicSupport
{
    class SalesPerson: Employee
    {
        public SalesPerson(string name, int id, int age, float pay, string socialSecurityNumber, int salesNumber) : base(name, id, age, pay, socialSecurityNumber)
        {
            SalesNumber = salesNumber;
        }

        public int SalesNumber { get; set; }
        // A salesperson's bonus is influenced by the number of sales.
        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
    }
}
