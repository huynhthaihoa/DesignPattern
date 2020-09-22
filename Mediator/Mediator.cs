using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Mediator
    {
        private Welcome welcome;
        private Shop shop;
        private Purchase purchase;
        private Exit exit;
        public Mediator()
        {
            welcome = new Welcome(this);
            shop = new Shop(this);
            purchase = new Purchase(this);
            exit = new Exit(this);
        }
        public void handle(string state)
        {
           if(state.Equals("Welcome,shop!"))
            {
                shop.go();
            } 
            else if(state.Equals("Shop,purchase!"))
           {
                purchase.go();
            }
           else if (state.Equals("Thank you for purchase"))
            {
                exit.go();
            } 
            else if(state.Equals("Welcome,exit!"))
           {
                exit.go();
            } 
           else if(state.Equals("Shop,exit!"))
           {
                exit.go();
           } 
           else if(state.Equals("Purchase.exit!"))
           {
                exit.go();
            }
        }
        public Welcome getWelcome()
        {
            return welcome;
        }
    }
}
