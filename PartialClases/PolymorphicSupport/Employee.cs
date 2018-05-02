using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphicSupport
{
    class Employee
    {
        public float Pay { get; private set; }
        public string Name { get; private set; }
        public int ID { get; private set; }
        public int Age { get; private set; }
        public string SocialSecurityNumber { get; private set; }

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
        public Employee(string name, int id, int age, float pay, string socialSecurityNumber )
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}
