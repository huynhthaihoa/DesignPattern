using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Disk : ComponentDecorator
    {
        private Computer computer;
        public Disk(Computer c)
        {
            computer = c;
        }
        public override string Description()
        {
            return computer.Description() + " and a disk";
        }
    }
}
