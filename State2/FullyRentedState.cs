using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State2
{
    class FullyRentedState:State
    {
        AutomatInterface automat;
        public FullyRentedState(AutomatInterface a)
        {
            automat = a;
        }
        public string gotApplication()
        {
            return "Sorry, we’re fully rented.";
        }
        public string checkApplication()
        {
            return "Sorry, we’re fully rented.";
        }
        public string rentApartment()
        {
            return "Sorry, we’re fully rented.";
        }
        public string dispenseKeys()
        {
            return "Sorry, we’re fully rented.";
        }
    }
}
