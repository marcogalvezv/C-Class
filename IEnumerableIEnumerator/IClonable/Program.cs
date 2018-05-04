using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee( 10, 5000 );
            Employee emp2 = (Employee)emp1.Clone();
            Console.WriteLine($"Emp1 Salary is: {emp1.Salary}");
            emp1.Salary = 10000;
            Console.WriteLine($"Emp1 Salary is: {emp1.Salary}");
            Console.WriteLine($"Emp2 Salary is: {emp2.Salary}");
            emp2.Salary = 7000;
            Console.WriteLine($"Emp1 Salary is: {emp1.Salary}");
            Console.WriteLine($"Emp2 Salary is: {emp2.Salary}");
            Console.ReadLine();
        }
    }
}
