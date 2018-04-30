using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    //class Employee
    //{// Field data.
    //    private string empName;
    //    private int empID;
    //    private float currPay;
    //    // Constructors.
    //    public Employee() { }
    //    public Employee(string name, int id, float pay)
    //    {
    //        empName = name;
    //        empID = id;
    //        currPay = pay;
    //    }
    //    // Methods.
    //    public void GiveBonus(float amount)
    //    {
    //        currPay += amount;
    //    }
    //    public void DisplayStats()
    //    {
    //        Console.WriteLine("Name: {0}", empName);
    //        Console.WriteLine("ID: {0}", empID);
    //        Console.WriteLine("Pay: {0}", currPay);
    //    }

    //    // Accessor (get method).
    //    public string GetName()
    //    {
    //        return empName;
    //    }
    //    // Mutator (set method).
    //    public void SetName(string name)
    //    {
    //        // Do a check on incoming value
    //        // before making assignment.
    //        if (name.Length > 15)
    //            Console.WriteLine("Error! Name length exceeds 15 characters!");
    //        else
    //            empName = name;
    //    }
    //}

    class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        //private int empAge;
        ////Properties as Expression-Bodied Members
        //public int Age
        //{
        //    get => empAge;
        //    set => empAge = value;
        //}

        public Employee() { }
        //public Employee(string name, int id, float pay)
        //: this(name, 0, id, pay) { }
        //public Employee(string name, int age, int id, float pay)
        //{
        //    empName = name;
        //    empID = id;
        //    empAge = age;
        //    currPay = pay;
        //}


        //public Employee(string empName, int empID, float currPay)
        //{
        //    this.empName = empName;
        //    this.empID = empID;
        //    this.currPay = currPay;
        //}

        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }
        // We could add additional business rules to the sets of these properties;
        // however, there is no need to do so for this example.
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        // Methods.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }

    }

}
