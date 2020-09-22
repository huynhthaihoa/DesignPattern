using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class CD : ComponentDecorator
    {
        private Computer computer;
        public CD(Computer c)
        {
            computer = c;
        }
        public override string Description()
        {
            return computer.Description() + " and a CD";
        }
    }
}
