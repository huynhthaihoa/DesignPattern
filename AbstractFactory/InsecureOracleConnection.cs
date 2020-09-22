using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class InsecureOracleConnection:Connection
    {
        public InsecureOracleConnection()
        { }
        public override string Description()
        {
            return "Oracle insecure";
        }
    }
}
