using System;
using System.Collections.Generic;
using System.Text;

namespace MicroBenchmarking.Entities
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int NumberOfOrders { get; set; }
    }
}
