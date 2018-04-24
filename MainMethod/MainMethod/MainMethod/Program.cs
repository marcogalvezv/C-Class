using System;

namespace MainMethod
{
    class Program
    {

        #region Variations on the Main( ) Method
        //// int return type, array of strings as the parameter.
        //static int Main(string[] args)
        //{
        //    // Must return a value before exiting!
        //    return 0;
        //}
        //// No return type, no parameters.
        //static void Main()
        //{
        //}
        //// int return type, no parameters.
        //static int Main()
        //{
        //    // Must return a value before exiting!
        //    return 0;
        //}
        #endregion

        #region incoming args
        static int Main(string[] args)
        {
            // Process any incoming args.
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg: {0}", args[i]);
            Console.ReadLine();
            return -1;
        }
        #endregion
    }
}