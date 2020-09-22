using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class SecureMySQLConnection:Connection
    {
        public SecureMySQLConnection()
        { }
        public override string Description()
        {
            return "My SQL secure ";
        }
    }
}
