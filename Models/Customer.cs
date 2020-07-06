using System;
using System.Collections.Generic;
using System.Text;

namespace CSHReflection.Models
{
    class Customer
    {

        public Customer()
        {
            //Defaults
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public string Address { get; set; }

        public bool Validate(Customer customerObj)

        {
            //Code to validate the customer object
            return true;
        }
    }
}
