using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State2
{
    interface AutomatInterface
    {
        void gotApplication();
        void checkApplication();
        void rentApartment();
        void setState(State s);
        State getWaitingState();
        State getGotApplicationState();
        State getApartmentRentedState();
        State getFullyRentedState();
        int getCount();
        void setCount(int n);
    }
}
