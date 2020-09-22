using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class SecureOracleConnection:Connection
    {
        public SecureOracleConnection()
        { }
        public override string Description()
        {
            return "Oracle secure";
        }
    }
}
