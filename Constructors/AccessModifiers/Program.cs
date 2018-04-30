using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    //Default Access Modifier
    // An internal class with a private default constructor.
    class Radio
    {
        Radio() { }
    }


    //// An internal class with a private default constructor.
    //internal class Radio
    //{
    //    private Radio() { }
    //}

    //// A public class with a public default constructor.
    //public class Radio
    //{
    //    public Radio() { }
    //}


    //Access Modifiers and Nested Types

    public class SportsCar
    {
        // OK! Nested types can be marked private.
        private enum CarColor
        {
            Red, Green, Blue
        }
    }



    //private class test
    //{

    //}
}