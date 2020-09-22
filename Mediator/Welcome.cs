using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Welcome
    {
        private Mediator mediator;
        private string response = "n";
        public Welcome(Mediator m)
        {
            mediator = m;
        }
        public void go()
        {
            Console.Write("Do you want to shop?(y/n)");
            do
            {
                response = Console.ReadLine();
                if (response != "y" && response != "Y" && response != "n" && response != "N")
                    Console.WriteLine("Error.Try again");
            }
            while (response != "y" && response != "Y" && response != "n" && response != "N");
            if (response.Equals("y") || response.Equals("Y"))
                mediator.handle("Welcome,shop!");
            if (response.Equals("n") || response.Equals("N"))
                mediator.handle("Welcome,exit!");
        }
    }
}
