using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class SQLServerConnection:Connection
    {
        public SQLServerConnection()
        { }
        public override string Description()
        {
            return "SQL Server ";
        }
    }
}
