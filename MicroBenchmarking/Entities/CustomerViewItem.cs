using System;
using System.Collections.Generic;
using System.Text;

namespace MicroBenchmarking.Entities
{
    public class CustomerViewItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int NumberOfOrders { get; set; }
    }
}
