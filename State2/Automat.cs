using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State2
{
    class Automat:AutomatInterface
    {
        private State waitingState;
        private State gotApplicationState;
        private State apartmentRentedState;
        private State fullyRentedState;
        private State state;
        private int count;
        public Automat(int n)
        {
            count = n;
            waitingState = new WaitingState(this);
            gotApplicationState = new GotApplicationState(this);
            apartmentRentedState = new ApartmentRentedState(this);
            fullyRentedState = new FullyRentedState(this);
            state = waitingState;
        }
        public void gotApplication()
        {
            Console.WriteLine(state.gotApplication());
        }
        public void checkApplication()
        {
            Console.WriteLine(state.checkApplication());
        }
        public void rentApartment()
        {
            Console.WriteLine(state.rentApartment());
            Console.WriteLine(state.dispenseKeys());
        }
        public State getGotApplicationState()
        {
            return gotApplicationState;
        }
        public State getWaitingState()
        {
            return waitingState;
        }
        public State getApartmentRentedState()
        {
            return apartmentRentedState;
        }
        public State getFullyRentedState()
        {
            return fullyRentedState;
        }
        public int getCount()
        {
            return count;
        }
        public void setCount(int n)
        {
            count = n;
        }
        public void setState(State s)
        {
            state = s;
        }
    }
}
