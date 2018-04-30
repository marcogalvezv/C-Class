﻿using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            • Data of a class
            • Methods of a class
            • Properties of a class
            • A constructor
            • The entire class definition*/

            Console.WriteLine("***** Fun with Static Data *****\n");
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            // Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            // Make new object, this does NOT 'reset' the interest rate.
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();
        }
    }


    // A simple savings account class.
    class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;
        // A static point of data.
        public static double currInterestRate = 0.04;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }

        // A static constructor!
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }
    }
}