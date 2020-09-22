using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class SecureSQLServerConnection:Connection
    {
        public SecureSQLServerConnection()
        { }
        public override string Description()
        {
            return "SQL Server secure";
        }
    }
}
