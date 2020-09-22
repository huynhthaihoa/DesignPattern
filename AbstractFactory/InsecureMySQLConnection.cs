using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class InsecureMySQLConnection:Connection
    {
        public InsecureMySQLConnection()
        { }
        public override string Description()
        {
            return "My SQL insecure ";
        }
    }
}
