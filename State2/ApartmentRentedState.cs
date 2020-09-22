using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State2
{
    class ApartmentRentedState:State
    {
        private AutomatInterface automat;
        public ApartmentRentedState(AutomatInterface a)
        {
            automat = a;
        }
        public string gotApplication()
        {
            return "Hang on, we’re renting you an apartment.";
        }
        public string checkApplication()
        {
            return "Hang on, we’re renting you an apartment.";
        }
        public string rentApartment()
        {
            automat.setCount(automat.getCount() - 1);
            return "Renting you an apartment....";
        }
        public string dispenseKeys()
        {
            if(automat.getCount() <= 0)
            { 
                automat.setState(automat.getFullyRentedState());
            } 
            else 
            {
                automat.setState(automat.getWaitingState());
            }
            return "Here are your keys!";
        }
    }
}
