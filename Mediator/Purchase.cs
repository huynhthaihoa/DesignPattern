using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Purchase
    {
        private Mediator mediator;
        private string response = "n";
        public Purchase(Mediator m)
        {
            mediator = m;
        }
        public void go()
        {
            Console.Write("Buy the item now?(y/n)");
            do
            {
                response = Console.ReadLine();
                if (response != "y" && response != "Y" && response != "n" && response != "N")
                    Console.WriteLine("Error.Try again");
            }
            while (response != "y" && response != "Y" && response != "n" && response != "N");
            if (response.Equals("y") || response.Equals("Y"))
                mediator.handle("Thank you for purchase");
            if (response.Equals("n") || response.Equals("N"))
                mediator.handle("Purchase,exit!");
        }
    }
}
