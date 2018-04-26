using System;

namespace Enums
{
    class Program
    {
        // A custom enumeration.
        enum EmpType
        {
            Manager, // = 0
            Grunt, // = 1
            Contractor, // = 2
            VicePresident // = 3
        }



        // Begin with 102.
        enum EmpType2
        {
            Manager = 102,
            Grunt, // = 103
            Contractor, // = 104
            VicePresident // = 105
        }

        // Elements of an enumeration need not be sequential!
        enum EmpType3
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 9
        }


        // This time, EmpType maps to an underlying byte.
        enum EmpType4 : byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 9
        }


        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums *****");
            // Make an EmpType variable.
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.ReadLine();
        }
        // Enums as parameters.
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
    }
}