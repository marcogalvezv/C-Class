using System;

namespace PolymorphicSupport
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("***** The Employee Class Hierarchy *****\n");
    //        // A better bonus system!
    //        Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
    //        chucky.GiveBonus(300);
    //        chucky.DisplayStats();
    //        Console.WriteLine();
    //        SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
    //        fran.GiveBonus(200);
    //        fran.DisplayStats();
    //        Console.ReadLine();
    //    }
    //}

//Method hiding 
    class A
    {
        public void Foo() { Console.WriteLine("A::Foo()"); }
    }

    class B : A
    {
        public new void Foo() { Console.WriteLine("B::Foo()"); }
    }

    class Test
    {
        static void Main(string[] args)
        {
            A a;
            B b;

            a = new A();
            b = new B();
            a.Foo();  // output --> "A::Foo()"
            b.Foo();  // output --> "B::Foo()"

            a = new B();
            a.Foo();  // output --> "A::Foo()"
            Console.ReadLine();
        }
    }


}