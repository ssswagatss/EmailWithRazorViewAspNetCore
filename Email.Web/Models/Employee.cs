﻿using System.Collections.Generic;

namespace Email.Web.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
