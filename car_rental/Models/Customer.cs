using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace car_rental.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        // TODO: Add körkortsuppgifter / Drivers license info
    }
}