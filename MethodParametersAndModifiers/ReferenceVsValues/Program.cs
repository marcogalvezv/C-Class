using System;

namespace ReferenceVsValues
{
    class Program
    {
        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }

        public static void Main()
        {
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);
        }


        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }

        static void Main2(string[] args)
        {
            Student std1 = new Student();
            std1.StudentName = "Bill";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
        }
    }
    class Student
    {
        public string StudentName { get; set; }
    }
}