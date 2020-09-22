using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State2
{
    class WaitingState:State
    {
        private AutomatInterface automat;
        public WaitingState(AutomatInterface a)
        {
            automat = a;
        }
        public string gotApplication()
        {
            automat.setState(automat.getGotApplicationState());
            return "Thanks for the application.";
        }
        public String checkApplication()
        {
            return "You have to submit an application.";
        }
        public String rentApartment()
        {
            return "You have to submit an application.";
        }
        public String dispenseKeys()
        {
            return "You have to submit an application.";
        }
    }
}
