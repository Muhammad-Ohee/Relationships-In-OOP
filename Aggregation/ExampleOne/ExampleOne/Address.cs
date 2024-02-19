using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public void GetAddress()
        {
            Console.WriteLine($"Street: {Street}" +
                              $"\nCity: {City}" +
                              $"\nState: {State}" +
                              $"\nPostalcode: {PostalCode}");
        }
    }
}
