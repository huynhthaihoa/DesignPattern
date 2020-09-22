using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Monitor : ComponentDecorator
    {
        private Computer computer;
        public Monitor(Computer c)
        {
            computer = c;
        }
        public override string Description()
        {
            return computer.Description() + " and a monitor";
        }
    }
}
