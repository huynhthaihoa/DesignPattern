using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    abstract class Corporate
    {
        public virtual string getName()
        {
            return " ";
        }
        public virtual void Add(Corporate c)
        { }
        public virtual Iterator iterator()
        {
            return null;
        }
        public virtual void print()
        { }

    }
}
