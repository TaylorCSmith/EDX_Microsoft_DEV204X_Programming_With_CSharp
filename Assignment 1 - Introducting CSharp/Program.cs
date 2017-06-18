﻿// Instructions
// 1.  Create a C# Console application.
// 2.  Within the Main() method in this application, create variables of the correct data type for the information 
// related to a student only.  The other information will be used in later modules when you create class files for 
// the other objects listed:
// 3.  Once you have the variables created, use assignment statements to assign values to one set of student variables 
// and use the Console.WriteLine() method to output the values to the console window.

// Again, this assignment is merely intended to check your understanding of how to create variables, assign values to 
// them, and output the information to a console window.  You will build on these concepts and begin to create more 
// functionality in later modules.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        // initialize variables 
            string firstName;
            string lastName;
            DateTime birthdate;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            int zipPostalCode;
            string country;
            
        // values assigned to variables
            firstName = "Johnny";
            lastName = "Appleseed";
            birthdate = new DateTime(1774, 09, 26);
            addressLine1 = "3243 Apple Street";
            addressLine2 = "Floor 1";
            city = "Leominster";
            stateProvince = "Massachusetts";
            zipPostalCode = 32432;
            country = "British America";

        // output the values of the variables using Console.WriteLine("..."); 
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthdate);
            Console.WriteLine(addressLine1);
            Console.WriteLine(addressLine2);
            Console.WriteLine(city);
            Console.WriteLine(stateProvince);
            Console.WriteLine(zipPostalCode);
            Console.WriteLine(country);
        }
    }
}