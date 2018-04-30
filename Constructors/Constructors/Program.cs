using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Fun with Class Types *****\n");
            //// Invoking the default constructor.
            //Car chuck = new Car();
            //// Prints "Chuck is going 10 MPH."
            //chuck.PrintState();


            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name); // Prints an empty name value!
        }
    }

    class Car
    {
        // The 'state' of the Car.
        public string petName;
        public int currSpeed;
        // A custom default constructor.
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        
        //Constructors as Expression-Bodied Members
        // Here, currSpeed will receive the
        // default value of an int (zero).
        public Car(string pn) => petName = pn;

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.",petName,currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }


    class Motorcycle
    {
        public int driverIntensity;
        // New members to represent the name of the driver.
        public string name;
        public string driverName;
        public void SetDriverName(string name)
        {
            name = name;
        }

        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeeee Haaaaaeewww!");
        }

        public Motorcycle(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }

        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }

    }

    class Motorcycle1
    {
        public int driverIntensity;
        public string driverName;
        // Constructor chaining.
        public Motorcycle1() { }
        public Motorcycle1(int intensity)
        : this(intensity, "") { }
        public Motorcycle1(string name)
        : this(0, name) { }
        // This is the 'master' constructor that does all the real work.
        public Motorcycle1(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
}
}