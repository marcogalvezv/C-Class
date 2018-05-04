using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonable
{
    class Employee: ICloneable
    {
        public int Id { get; set; }
        public int Salary { get; set; }

        public Employee(int id, int salary)
        {
            Id = id;
            Salary = salary;
        }
        public object Clone()
        {
            return new Employee(Id,Salary);
        }
    }


}
