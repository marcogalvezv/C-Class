﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQToCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****\n");
            // Make a List<> of Car objects.
            List<Car> myCars = new List<Car>() {
            new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
            new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
            new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
            new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
            new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };
            Console.ReadLine();
        }


        static void GetFastCars(List<Car> myCars)
        {
            // Find all Car objects in the List<>, where the Speed is
            // greater than 55.
            var fastCars = from c in myCars where c.Speed > 55 select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }


        static void GetFastBMWs(List<Car> myCars)
        {
            // Find the fast BMWs!
            var fastCars = from c in myCars where c.Speed > 90 && c.Make == "BMW" select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }
    }
}