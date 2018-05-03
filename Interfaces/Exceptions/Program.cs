using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);

            //for (int i = 0; i < 10; i++)
            //    myCar.Accelerate(10);
            //Console.ReadLine();


            // Speed up past the car's max speed to
            // trigger the exception.
            try
            {
                //var e = 0;
                //var t = 10 / e;

                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Another Error! ***");
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }

            finally
            {
                Console.WriteLine("Finally statement");
            }
            // The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();
        }
    }
}