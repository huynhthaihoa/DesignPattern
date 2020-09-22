using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class OracleConnection:Connection
    {
        public OracleConnection()
        { }
        public override string Description()
        {
            return "Oracle ";
        }
    }
}
