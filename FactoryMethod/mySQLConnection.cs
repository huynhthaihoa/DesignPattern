using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class mySQLConnection:Connection
    {
        public mySQLConnection()
        { }
        public override string Description()
        {
            return "my SQL ";
        }
    }
}
