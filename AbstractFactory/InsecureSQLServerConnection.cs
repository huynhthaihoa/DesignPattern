using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class InsecureSQLServerConnection:Connection
    {
         public InsecureSQLServerConnection()
        { }
        public override string Description()
        {
            return "SQL Server insecure";
        }
    }
}
