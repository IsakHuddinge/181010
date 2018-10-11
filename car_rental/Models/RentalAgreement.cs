using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace car_rental.Models
{
    public class RentalAgreement
    {
        public int ID { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public DateTime FromRentalTime { get; set; }
        public DateTime ToRentalTime { get; set; }
        
    }
}