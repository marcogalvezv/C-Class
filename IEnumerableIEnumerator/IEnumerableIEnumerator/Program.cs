using System;

namespace IEnumerableIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iterate over an array of items.
            int[] myArrayOfInts = { 10, 20, 30, 40 };
            foreach (int i in myArrayOfInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");
            Garage carLot = new Garage();
            // Hand over each car in the collection?
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH",
                c.PetName, c.CurrentSpeed);
            }

            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH",
                c.PetName, c.CurrentSpeed);
            }
            Console.ReadLine();
        }
    }
}