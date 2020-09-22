using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Exit
    {
        private Mediator mediator;
        public Exit(Mediator m)
        {
            mediator = m;
        }
        public void go()
        {
            Console.WriteLine("Please come again sometimes.");
        }
    }
}
