using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Computer
    {
        public Computer()
        { }
        public virtual string Description()
        {
            return "a computer";
        }
    }
}
