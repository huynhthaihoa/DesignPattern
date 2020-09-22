using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class ConnectionFactory
    {
        public ConnectionFactory()
        { }
        public abstract Connection createConnection(string type);
    }
}
