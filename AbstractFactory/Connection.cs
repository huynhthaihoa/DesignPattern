using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class Connection
    {
        public Connection()
        { }
        public virtual string Description()
        {
            return "Generic";
        }
    }
}
