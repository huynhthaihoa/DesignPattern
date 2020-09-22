using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State2
{
    class GotApplicationState:State
    {
        private AutomatInterface automat;
        private Random random;
        public GotApplicationState(AutomatInterface a)
        {
            automat = a;
            random = new Random(DateTime.Now.Millisecond);
        }
        public string gotApplication()
        { 
            return "We already got your application.";
        }
        public string checkApplication()
        {
            int yesno = random.Next() % 10;
            if (yesno > 4 && automat.getCount() > 0)
            {
                automat.setState(automat.getApartmentRentedState());
                return "Congratulation,you're approved.";
            }
            automat.setState(automat.getWaitingState());
            return "Sorry,you're not approved.";
        }
        public string rentApartment()
        {
            return "You must have your application checked.";
        }
        public string dispenseKeys()
        {
            return "You must have your application checked.";
        }
    }
}
