using System;
using System.Collections.Generic;
using System.Text;

namespace F26W2IntroToClasses
{
    // primary constructor example
    public class Student(string firstName, string lastName)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;

        //public Student(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}
    }
}
