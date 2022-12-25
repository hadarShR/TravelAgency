using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel_Agency.Models;

namespace Travel_Agency.ViewModel
{
    public class FlightViewModel
    {
        public Flight flight { get; set; }
        public List<Flight> flightsList { get; set; }
    }
}